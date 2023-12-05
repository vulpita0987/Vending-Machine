using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Timers;
using System.Collections.Specialized;

//the extra headers enable better functionality


namespace VendingMachine
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
            tmr.Start();//timer  used for the timeout prompt 
            //keeps track of time since the program starts running
        }

       
        bool pickSkittles = false;
        bool pickHaribo = false;
        bool pickFanta = false;
        bool pickCocaCola = false;
        bool pickWalkers = false;
        bool pickQuavers = false;
        bool clickCheckout = false;
        bool dragToBin = false;
        bool dragToCoinslot = false;
        bool clickCancelOrder = false;
        //these bools keep track of the user's input
        //all false at run time - because there is no input from user yet
        public int secondsCount = 0;
        //secondsCount will keep track of the seconds that pass 
        private void tmr_Tick(object sender, EventArgs e)
        {
            secondsCount++;
            //secondsCount is incremented each time a second passes/ each time the code of the timer is run

            if (secondsCount == 15) //when the timer has been run 15 times (15 seconds have passed) - access this if
            {
                //if none of the bools are true then the user has not clicked any button
                //in which case access the following if
                if ((pickSkittles == false) && (pickHaribo == false) && (pickFanta == false) && (pickCocaCola == false) && (pickWalkers == false) && (pickQuavers == false)
                     && (dragToBin == false) && (dragToCoinslot == false) && (clickCheckout == false) && (clickCancelOrder == false))
                {

                    //if the user provided some input but then they stopped providing input 
                    //access this if statement
                    if (lblLastAction.Text != "Last Action: None") {
                        tmr.Stop();
                        lblPrompt.Visible = true;//shows a warning to the user
                        lblPrompt.Text = "Vending Machine will reset in 10 second without input";
                        tmrEnd.Start();//starts the second times
                    }

                    //if the user has not clicked on anything since the program started running then access this if statement
                    //this makes sure that the vending machine does not reset needlessly 
                    if (lblLastAction.Text == "Last Action: None") { lblPrompt.Visible = false; tmrEnd.Stop(); tmr.Start(); }

                }
                secondsCount = 0;//reset secondsCount each time 15 seconds have passed

                pickSkittles = false;
                pickHaribo = false;
                pickFanta = false;
                pickCocaCola = false;
                pickWalkers = false;
                pickQuavers = false;
                clickCheckout = false;
                dragToBin = false;
                dragToCoinslot = false;
                clickCancelOrder = false;
                //bools are set to false at the end of 15 seconds - reset whole operation - ready to start again
            }

          
        }

        public int secondsCount1 = 0;//keeps track of seconds that pass in second timer
        public int labelChange = 10;//used to show the user how many seconds are left before the machine restarts
        private void tmrEnd_Tick(object sender, EventArgs e)
        {
            secondsCount1++;//increase this everytime the code of this timer is run
            
            //display label - user needs to be aware that the machine will reset without input
            lblPrompt.Text = "Vending Machine will reset in "+ labelChange + " second without input";
            
            labelChange--;//change the value each time timer code runs 


            //if the user clicks anything while the warning is visible access if statement
            if ((pickSkittles == true) || (pickHaribo == true) || (pickFanta == true) || (pickCocaCola == true) || (pickWalkers == true) || (pickQuavers == true)
                     || (dragToBin == true) || (dragToCoinslot == true) || (clickCheckout == true) || (clickCancelOrder == true))
            {

                lblPrompt.Visible = false;
                tmrEnd.Stop();
                tmr.Start();
                secondsCount1 = 0; 
                labelChange = 10;
                //reset timers - start again

            }

            
            //if 11 seconds have passed and user there is not input access this if statement
            if ((secondsCount1 == 11) && (lblPrompt.Visible == true)) { Reset(); tmrEnd.Stop(); tmr.Start(); }
            //whenever 11 seconds pass - reset the seconds count and the number that shows in the warning
            if (secondsCount1 == 11) { secondsCount1 = 0; labelChange = 10; }
        }



        int orders = 0;
        string totalToWrite = "none";//used to store the total that the user has to pay - right before going to checkout
        string changeToWrite = "none";//used to store the change after the user fisishes paying
        bool firstRun = true;//used to check if this is the first time this part of code is run
        void WriteToFile()
        {
            DateTime present = DateTime.Now; //diplays the date and time of the orders - each time the program is run

            orders++;//increments number of orders - each time this code is run 
            var path = "Orders.txt"; //names the text file where the orders will be stored
            using var file = new StreamWriter(path, append : true);//creates the text file if one does not exist already
            //appends the text to the text file - no overriding

            //this if statement makes sure that the date and time only shows up once - each the the program starts running
            if (firstRun == true) { firstRun = false; file.WriteLine(present.ToString("F")); }
           

            //these 2 line help keep the text file tidy
            file.WriteLine("Order " + orders.ToString() );
            file.WriteLine(" ");

            string products = "none";//used to store the products in the text file 

            //for loop used to display the products in the text file
            for (int i = 0; i < lstItemsPicked.Items.Count; i++)
            {
                products = lstItemsPicked.Items[i].ToString();
                file.WriteLine(products);
            }

            file.WriteLine(totalToWrite);//write the total of the order to text file
            file.WriteLine(changeToWrite);//write the change to text file
            file.WriteLine(" ");//keeps text file tidy - add extra space

          

            file.Close();//close text file - to avoid errors
        }
        private void Form1_Load(object sender, EventArgs e)//when form loads access this
        {
            //allow drag and drop to happen
            btnCoinslot.AllowDrop = true;
            pbBin.AllowDrop = true;

        }

        void Price(double addedPrice)//used to set the price in the lblTotal
        {
            int index = lblTotal.Text.IndexOf('£');//find the index of £ in text of the label
            string labelText = lblTotal.Text;//store text of label into string variable
            labelText = labelText.Remove(0, index + 1);//remove everything before the £ sign and store it into the string
            double.TryParse(labelText, out double previousPrice);//convert result to double and store into double
            double total = previousPrice + addedPrice;//add the price of the new item to the previous price
            lblTotal.Text = "Total: £" + string.Format("{0:0.00}", total);//display in label - converted to string


        }

        
        void Reset()//used to reset whole form
        {
            grpChoice.Enabled = true;
            grpCheckout.Enabled = false;
            lblTotal.Text = "Total: £0.00";
            lstItemsPicked.Items.Clear();
            lblLastAction.Text = "Last Action: None";
            
            lblPrompt.Visible = false;
            pickSkittles = false;
            pickHaribo = false;
            pickFanta = false;
            pickCocaCola = false;
            pickWalkers = false;
            pickQuavers = false;
            clickCheckout = false;
            dragToBin = false;
            dragToCoinslot = false;
            clickCancelOrder = false;

            hariboButtonFirst = true; 
            skittlesButtonFirst = true; 
            cocaColaButtonFirst = true;
             fantaButtonFirst = true;
             walkersButtonFirst = true; 
             quaversButtonFirst = true;

        }

        
        void DisableMoney()//when called does not allow user to drag and drom the money 
        {
            //disable buttons
            btn20Pound.Enabled = false;
            btn10Pound.Enabled = false;
            btn5Pound.Enabled = false;
            btn2Pound.Enabled = false;
            btn1Pound.Enabled = false;
            btn50Pence.Enabled = false;
            btn20Pence.Enabled = false;
            btn10Pence.Enabled = false;


        }

        void EnableMoney()//when called alows user to drag and drop money 
        {
            //enables money
            btn20Pound.Enabled = true;
            btn10Pound.Enabled = true;
            btn5Pound.Enabled = true;
            btn2Pound.Enabled = true;
            btn1Pound.Enabled = true;
            btn50Pence.Enabled = true;
            btn20Pence.Enabled = true;
            btn10Pence.Enabled = true;

        }

        
        void AddItemToList(string product)//used to add new item to list box
        {
            //add new item to list box
            lstItemsPicked.Items.Add(product);

        }

       

        bool skittlesButtonFirst = true;//used to tell compiler if it is the first time the button has been clicked 
        //after run or reset
        private void btnSkittles_Click(object sender, EventArgs e)
        {
            pickSkittles = true;//used for timeout prompt - if true -> it means user has added this item to basket
            lblLastAction.Text = "You have added a bag of Skittles to your cart";//displays this in btnLastAction - informs user of their last action
            if (skittlesButtonFirst == true) { AddItemToList("Skittles * 1"); }//if it's the first time the item is added to basket - write this into list box
            Price(3);//function call - icreases total by £3
           
            string mes = lstItemsPicked.Items.Count.ToString();//count how many items there are in basket - store result in string
            int numberItems = 0;//initialise integer to hold number of items
            numberItems = int.Parse(mes);//put number of items into int
            int many = 0;//initialised to keep track how many products of this type there are in the basket
            
            for (int i = 0; i < numberItems; i++)//counts how many products of this type (skittles) are in the basket and displays that in the list box
            {
                
                string product = lstItemsPicked.Items[i].ToString();//get product at the specific position in loop - and store it into a string
                int lenght = product.Length;//store the lenght of the product in an int
                
                int index = product.IndexOf('*') + 2;//find index of '*' add 2 to it
                string product1;
                product1 = product.Remove(index, lenght - index);//store everything before price in string
                
                string many1 = product.Remove(0, index);//store everything after * in string
                many = Int32.Parse(many1);//convert number as text into number an int

                //if added product matches this product and it's not the first time the button has been clicked access this if
                if ((product1.ToString() == "Skittles * ") && (skittlesButtonFirst == false))
                {
                    
                     many++;//increase number of same product
                    lstItemsPicked.Items.RemoveAt(i);//remove item that was added when button was clicked - from list box
                    lstItemsPicked.Items.Add("Skittles * " + many.ToString());//diaplay new count for item in list box
                    

                }
                
            }
            skittlesButtonFirst = false;//set to false - next time button is clicked - program knows it is not clicked the first time
            


        }

        bool hariboButtonFirst = true;//used to tell compiler if it is the first time the button has been clicked 
        //after run or reset
        private void btnHaribo_Click(object sender, EventArgs e)
        {
           
            pickHaribo = true;//used for timeout prompt - if true -> it means user has added this item to basket

            lblLastAction.Text = "You have added a bag of Haribo to your cart";//displays this in btnLastAction - informs user of their last action
            if (hariboButtonFirst == true) { AddItemToList("Haribo * 1"); }//if it's the first time the item is added to basket - write this into list box
            Price(2.50);//function call - icreases total by £2.50

            string mes = lstItemsPicked.Items.Count.ToString();//count how many items there are in basket - store result in string
            int numberItems = 0;
            numberItems = int.Parse(mes);// put number of items into int
            int many = 0;//initialised to keep track how many products of this type there are in the basket

            for (int i = 0; i < numberItems; i++)//counts how many products of this type (haribo) are in the basket and displays that in the list box
            {

                string product = lstItemsPicked.Items[i].ToString();//get product at the specific position in loop - and store it into a string
                int lenght = product.Length;//store the lenght of the product in an int

                int index = product.IndexOf('*') + 2;//find index of '*' add 2 to it
                string product1;
                product1 = product.Remove(index, lenght - index);//store everything before price in string

                string many1 = product.Remove(0, index);//store everything after * in string
                many = Int32.Parse(many1);//convert number as text into number an int

                //if added product matches this product and it's not the first time the button has been clicked access this if
                if ((product1.ToString() == "Haribo * ") && (hariboButtonFirst == false))
                {
                    many++;//increase number of same product
                    lstItemsPicked.Items.RemoveAt(i);//remove item that was added when button was clicked - from list box
                    lstItemsPicked.Items.Add("Haribo * " + many.ToString());//diaplay new count for item in list box

                }

            }

            hariboButtonFirst = false;//set to false - next time button is clicked - program knows it is not clicked the first time

        }

        bool walkersButtonFirst = true;//used to tell compiler if it is the first time the button has been clicked 
        //after run or reset
        private void btnWalkers_Click(object sender, EventArgs e)
        {
           
             pickWalkers = true;//used for timeout prompt - if true -> it means user has added this item to basket

            lblLastAction.Text = "You have added a bag of Walkers to your cart";//displays this in btnLastAction - informs user of their last action
            if (walkersButtonFirst == true) { AddItemToList("Walkers * 1"); };//if it's the first time the item is added to basket - write this into list box
            Price(1.50);//function call - icreases total by £1.50

            string mes = lstItemsPicked.Items.Count.ToString();//count how many items there are in basket - store result in string
            int numberItems = 0;
            numberItems = int.Parse(mes);// put number of items into int
            int many = 0;//initialised to keep track how many products of this type there are in the basket

            for (int i = 0; i < numberItems; i++)//counts how many products of this type (walkers) are in the basket and displays that in the list box
            {

                string product = lstItemsPicked.Items[i].ToString();//get product at the specific position in loop - and store it into a string
                int lenght = product.Length;//store the lenght of the product in an int

                int index = product.IndexOf('*') + 2;//find index of '*' add 2 to it
                string product1;
                product1 = product.Remove(index, lenght - index);//store everything before price in string

                string many1 = product.Remove(0, index);//store everything after * in string
                many = Int32.Parse(many1);// convert number as text into number an int

                //if added product matches this product and it's not the first time the button has been clicked access this if
                if ((product1.ToString() == "Walkers * ") && (walkersButtonFirst == false))
                {
                    many++;//increase number of same product
                    lstItemsPicked.Items.RemoveAt(i);//remove item that was added when button was clicked - from list box
                    lstItemsPicked.Items.Add("Walkers * " + many.ToString());//diaplay new count for item in list box

                }

            }

            walkersButtonFirst = false;//set to false - next time button is clicked - program knows it is not clicked the first time

        }

        bool quaversButtonFirst = true;//used to tell compiler if it is the first time the button has been clicked 
        //after run or reset
        private void btnQuavers_Click(object sender, EventArgs e)
        {
            pickQuavers = true;//used for timeout prompt - if true -> it means user has added this item to basket

            lblLastAction.Text = "You have added a bag of Quavers to your cart";//displays this in btnLastAction - informs user of their last action
            if (quaversButtonFirst == true) { AddItemToList("Quavers * 1"); }//if it's the first time the item is added to basket - write this into list box
            Price(1.50);//function call - icreases total by £1.50

            string mes = lstItemsPicked.Items.Count.ToString();//count how many items there are in basket - store result in string
            int numberItems = 0;
            numberItems = int.Parse(mes);// put number of items into int
            int many = 0;//initialised to keep track how many products of this type there are in the basket

            for (int i = 0; i < numberItems; i++)//counts how many products of this type (quavers) are in the basket and displays that in the list box
            {

                string product = lstItemsPicked.Items[i].ToString();//get product at the specific position in loop - and store it into a string
                int lenght = product.Length;//store the lenght of the product in an int

                int index = product.IndexOf('*') + 2;// find index of '*' add 2 to it
                string product1;
                product1 = product.Remove(index, lenght - index);//store everything before price in string

                string many1 = product.Remove(0, index);//store everything after * in string
                many = Int32.Parse(many1);// convert number as text into number an int

                //if added product matches this product and it's not the first time the button has been clicked access this if
                if ((product1.ToString() == "Quavers * ") && (quaversButtonFirst == false))
                {
                    many++;//increase number of same product
                    lstItemsPicked.Items.RemoveAt(i);//remove item that was added when button was clicked - from list box
                    lstItemsPicked.Items.Add("Quavers * " + many.ToString());//diaplay new count for item in list box

                }

            }

            quaversButtonFirst = false;// set to false - next time button is clicked - program knows it is not clicked the first time


        }

        bool fantaButtonFirst = true;//used to tell compiler if it is the first time the button has been clicked 
                                     //after run or reset
        private void btnFanta_Click(object sender, EventArgs e)
        {
            pickFanta = true;//used for timeout prompt - if true -> it means user has added this item to basket
            lblLastAction.Text = "You have added a bottle of Fanta to your cart";//displays this in btnLastAction - informs user of their last action
            if (fantaButtonFirst == true) { AddItemToList("Fanta * 1"); }//if it's the first time the item is added to basket - write this into list box
            Price(3);//function call - icreases total by £3

            string mes = lstItemsPicked.Items.Count.ToString();//count how many items there are in basket - store result in string
            int numberItems = 0;
            numberItems = int.Parse(mes);// put number of items into int
            int many = 0;//initialised to keep track how many products of this type there are in the basket

            for (int i = 0; i < numberItems; i++)//counts how many products of this type (fanta) are in the basket and displays that in the list box
            {

                string product = lstItemsPicked.Items[i].ToString();//get product at the specific position in loop - and store it into a string
                int lenght = product.Length;//store the lenght of the product in an int

                int index = product.IndexOf('*') + 2;// find index of '*' add 2 to it
                string product1;
                product1 = product.Remove(index, lenght - index);//store everything before price in string

                string many1 = product.Remove(0, index);//store everything after * in string
                many = Int32.Parse(many1);// convert number as text into number an int

                //if added product matches this product and it's not the first time the button has been clicked access this if
                if ((product1.ToString() == "Fanta * ") && (fantaButtonFirst == false))
                {
                    many++;//increase number of same product
                    lstItemsPicked.Items.RemoveAt(i);//remove item that was added when button was clicked - from list box
                    lstItemsPicked.Items.Add("Fanta * " + many.ToString());//diaplay new count for item in list box

                }

            }

            fantaButtonFirst = false;// set to false - next time button is clicked - program knows it is not clicked the first time

        }

        bool cocaColaButtonFirst = true;//used to tell compiler if it is the first time the button has been clicked 
                                        //after run or reset
        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            pickCocaCola = true;//used for timeout prompt - if true -> it means user has added this item to basket
            lblLastAction.Text = "You have added a bottle of CocaCola to your cart";//displays this in btnLastAction - informs user of their last action
            if (cocaColaButtonFirst == true) { AddItemToList("CocaCola * 1"); }//if it's the first time the item is added to basket - write this into list box
            Price(3);//function call - icreases total by £3

            string mes = lstItemsPicked.Items.Count.ToString();//count how many items there are in basket - store result in string
            int numberItems = 0;
            numberItems = int.Parse(mes);// put number of items into int
            int many = 0;//initialised to keep track how many products of this type there are in the basket

            for (int i = 0; i < numberItems; i++)//counts how many products of this type (cocaCola) are in the basket and displays that in the list box
            {

                string product = lstItemsPicked.Items[i].ToString();//get product at the specific position in loop - and store it into a string
                int lenght = product.Length;//store the lenght of the product in an int

                int index = product.IndexOf('*') + 2;// find index of '*' add 2 to it
                string product1;
                product1 = product.Remove(index, lenght - index);//store everything before price in string

                string many1 = product.Remove(0, index);//store everything after * in string
                many = Int32.Parse(many1);// convert number as text into number an int

                //if added product matches this product and it's not the first time the button has been clicked access this if
                if ((product1.ToString() == "CocaCola * ") && (cocaColaButtonFirst == false))
                {
                    many++;//increase number of same product
                    lstItemsPicked.Items.RemoveAt(i);//remove item that was added when button was clicked - from list box
                    lstItemsPicked.Items.Add("CocaCola * " + many.ToString());//diaplay new count for item in list box

                }

            }

            cocaColaButtonFirst = false;// set to false - next time button is clicked - program knows it is not clicked the first time


        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            clickCheckout = true;//used for timeout prompt - if true -> it means user has clicked this button
            //if user has does not have any items in basket - access this part of if statement
            if (lstItemsPicked.Items.Count == 0) { MessageBox.Show("You have to select at least 1 item to go to Checkout"); lblLastAction.Text = "You clicked Checkout but you had not items in your cart"; }
            else
            {
                //next 2 lines make sure that the user can not change their order - they can only pay now
                grpChoice.Enabled = false;
                grpCheckout.Enabled = true;
                EnableMoney();//makes sure money buttons can be used
                totalToWrite = lblTotal.Text;//used to write total in text file 


                lblLastAction.Text = "You clicked Checkout";//updates last action label
            }
            
        }

        private void btn20Pound_MouseDown(object sender, MouseEventArgs e)
        {
            btn20Pound.DoDragDrop(btn20Pound.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }

        private void btn10Pound_MouseDown(object sender, MouseEventArgs e)
        {
            btn10Pound.DoDragDrop(btn10Pound.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }


        private void btn5Pound_MouseDown(object sender, MouseEventArgs e)
        {
            btn5Pound.DoDragDrop(btn5Pound.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }

        private void btn2Pound_MouseDown(object sender, MouseEventArgs e)
        {
            btn2Pound.DoDragDrop(btn2Pound.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }

        private void btn1Pound_MouseDown(object sender, MouseEventArgs e)
        {
            btn1Pound.DoDragDrop(btn1Pound.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }

        private void btn50Pence_MouseDown(object sender, MouseEventArgs e)
        {
            btn50Pence.DoDragDrop(btn50Pence.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }

        private void btn20Pence_MouseDown(object sender, MouseEventArgs e)
        {
            btn20Pence.DoDragDrop(btn20Pence.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }

        private void btn10Pence_MouseDown(object sender, MouseEventArgs e)
        {
            btn10Pence.DoDragDrop(btn10Pence.Tag, DragDropEffects.Copy);//used to allow drag and drop
            //copies what is in the tag of the button and passes it along
        }

        private void btnCoinslot_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;//allows what was in the tag of the mouseDown button to be copied further
        }

        private void btnCoinslot_DragDrop(object sender, DragEventArgs e)
        {
            dragToCoinslot = true;//used for timeout prompt - if true -> it means user has put money into the money slot
            double getRidOf = 0;
            getRidOf = Convert.ToDouble(e.Data.GetData(DataFormats.StringFormat));//stored copied data from tag into double


            //tell the user how much money they have put into the money slot - format depends on whether it was more than a pound or less
            if(getRidOf >= 1) { lblLastAction.Text = "You put £" + string.Format("{0:0.00}", getRidOf) + " into the Money Slot"; } else { lblLastAction.Text = "You put " + string.Format("{0:0.00}", getRidOf) + "pence into the Money Slot"; }
            
            Price(-getRidOf);//get rid of how much money the user has put in the slot - from the total 

            int index = lblTotal.Text.IndexOf('£');//find index of £ and store it in an int variable
            string labelText = lblTotal.Text;//store text of label used for total inro a string
            labelText = labelText.Remove(0, index + 1);//remore everything before the £ sign - including the £ sign and store it in a string
            double.TryParse(labelText, out double leftToPay);//store value from string into double


            double change = 0;//used to keep track of change
            if (leftToPay <= 0)//if the total reached 0 or went under 0
            {

                DisableMoney();//does not allow user to keep inserting money


                int index1 = lblTotal.Text.IndexOf('£');//get index of £ and stores it in an int
                string labelText1 = lblTotal.Text;//stores text from lblTotal into string
                labelText1 = labelText1.Remove(0, index + 1);//get rid of eveyrything before £ - including the sign
                double.TryParse(labelText1, out change);//have the total stored in a double
                change = -change;//reverse the double - from negative to positive - that will be the change of the user
                changeToWrite = "Change: £" + string.Format("{0:0.00}", change);//put result in string - format properly - used to write to file
                lblTotal.Text = "Total: £0.00";//display this in total label - since there in no more money owed
                WriteToFile();//write to file
            }

            //if total goes under 0
            if (leftToPay < 0)
            {
                 //display the change in a message box
                MessageBox.Show("Change: £" + string.Format("{0:0.00}", change));
                Reset();//reset vending machine

            }

            //if total hits 0
            if (leftToPay == 0)
            {
                //display string in a message box
                MessageBox.Show("Change: £0.00");
                Reset();//reset vending machine

            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            clickCancelOrder = true;//used for timeout prompt - changed to true to tell program that the user has clicke this button

            //asking user if they are sure they want to cancel the order 
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the order?", "Warning", MessageBoxButtons.YesNo);

            //if user clicks 'yes'
            if (dialogResult == DialogResult.Yes)
            {
                lblLastAction.Text = "You canceled the order";//used to inform user of their last action - in lblLastAction
                Reset();//reset vending machine
            }

            //if user clicks 'no' 
            lblLastAction.Text = "You clicked cancel but decided to not cancel the order";//used to inform user of their last action - in lblLastAction
        }

        private void lstItemsPicked_MouseDown(object sender, MouseEventArgs e)
        {
            lstItemsPicked.DoDragDrop(lstItemsPicked.SelectedItem, DragDropEffects.Move);//allows item from List Box to be moved 
            
        }

        private void pbBin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) { e.Effect = DragDropEffects.Move; } else { e.Effect = DragDropEffects.None; }
            //allows contect from List Box to be passed on 
        }

        private void pbBin_DragDrop(object sender, DragEventArgs e)
        {
            dragToBin = true;//used for the timeout prompt - if it is true than user got rid of an item from the List Box
            string product = e.Data.GetData(DataFormats.Text).ToString();//store data that has been passed along into string

            int index = product.IndexOf('*') + 2;//find index of '*' add 2 to it
            string product1;

            int lenght = product.Length;//stores lengts of product in int variable
            product1 = product.Remove(index, lenght - index);//store everything before * in a string
            int many = 0;
            string many1 = product.Remove(0, index);//store everything after * in a string
            many = Int32.Parse(many1);//store value in an int variable instead of string

            //if there is only one product of the type in basket then get rid of it completely from the list
            //adapt the total, value of the bool and lblLastAction accordingly
            if (product == "Haribo * 1") { lstItemsPicked.Items.Remove(product); hariboButtonFirst = true; Price(-2.50); lblLastAction.Text = "You deleted a Haribo bag from your cart"; }
            if (product == "Skittles * 1") { lstItemsPicked.Items.Remove(product); skittlesButtonFirst = true; Price(-3); lblLastAction.Text = "You deleted a Skittles bag from your cart"; }
            if (product == "CocaCola * 1") { lstItemsPicked.Items.Remove(product); cocaColaButtonFirst = true; Price(-3); lblLastAction.Text = "You deleted a CocaCola bottle from your cart"; }
            if (product == "Fanta * 1") { lstItemsPicked.Items.Remove(product); fantaButtonFirst = true; Price(-3); lblLastAction.Text = "You deleted a Fanta bottle from your cart"; }
            if (product == "Walkers * 1") { lstItemsPicked.Items.Remove(product); walkersButtonFirst = true; Price(-1.50); lblLastAction.Text = "You deleted a bag of Walkers from your cart"; }
            if (product == "Quavers * 1") { lstItemsPicked.Items.Remove(product); quaversButtonFirst = true; Price(-1.50); lblLastAction.Text = "You deleted a bag of Quavers from your cart"; }

            //if there are multiple products of the same type in basket then get rid of one 
            //adapt the total, list box content and lblLastAction accordingly
            if (product1 == "Haribo * " && many != 1) { lstItemsPicked.Items.Remove(product); many = many - 1; lstItemsPicked.Items.Add("Haribo * " + many.ToString()); Price(-2.50); lblLastAction.Text = "You deleted a Haribo bag from your cart"; }
            if (product1 == "Skittles * " && many != 1) { lstItemsPicked.Items.Remove(product); many = many - 1; lstItemsPicked.Items.Add("Skittles * " + many.ToString()); Price(-3); lblLastAction.Text = "You deleted a Skittles bag from your cart"; }
            if (product1 == "CocaCola * " && many != 1) { lstItemsPicked.Items.Remove(product); many = many - 1; lstItemsPicked.Items.Add("CocaCola * " + many.ToString()); Price(-3); lblLastAction.Text = "You deleted a CocaCola bottle from your cart"; }
            if (product1 == "Fanta * " && many != 1) { lstItemsPicked.Items.Remove(product); many = many - 1; lstItemsPicked.Items.Add("Fanta * " + many.ToString()); Price(-3); lblLastAction.Text = "You deleted a Fanta bottle from your cart"; }
            if (product1 == "Walkers * " && many != 1) { lstItemsPicked.Items.Remove(product); many = many - 1; lstItemsPicked.Items.Add("Walkers * " + many.ToString()); Price(-1.50); lblLastAction.Text = "You deleted a bag of Walkers from your cart"; }
            if (product1 == "Quavers * " && many != 1) { lstItemsPicked.Items.Remove(product); many = many - 1; lstItemsPicked.Items.Add("Quavers * " + many.ToString()); Price(-1.50); lblLastAction.Text = "You deleted a bag of Quavers from your cart"; }



            
        }

       
    }
}