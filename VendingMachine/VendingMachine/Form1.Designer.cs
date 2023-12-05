namespace VendingMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpChoice = new System.Windows.Forms.GroupBox();
            this.pbBin = new System.Windows.Forms.PictureBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lstItemsPicked = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnHaribo = new System.Windows.Forms.Button();
            this.btnSkittles = new System.Windows.Forms.Button();
            this.btnWalkers = new System.Windows.Forms.Button();
            this.btnQuavers = new System.Windows.Forms.Button();
            this.btnFanta = new System.Windows.Forms.Button();
            this.btnCocaCola = new System.Windows.Forms.Button();
            this.pbFanta = new System.Windows.Forms.PictureBox();
            this.pbSkittles = new System.Windows.Forms.PictureBox();
            this.pbHaribo = new System.Windows.Forms.PictureBox();
            this.pbQuavers = new System.Windows.Forms.PictureBox();
            this.pbWalkers = new System.Windows.Forms.PictureBox();
            this.pbCocaCola = new System.Windows.Forms.PictureBox();
            this.grpCheckout = new System.Windows.Forms.GroupBox();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCoinslot = new System.Windows.Forms.Button();
            this.btn2Pound = new System.Windows.Forms.Button();
            this.btn10Pence = new System.Windows.Forms.Button();
            this.btn20Pence = new System.Windows.Forms.Button();
            this.btn5Pound = new System.Windows.Forms.Button();
            this.btn10Pound = new System.Windows.Forms.Button();
            this.btn50Pence = new System.Windows.Forms.Button();
            this.btn20Pound = new System.Windows.Forms.Button();
            this.btn1Pound = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.tmrEnd = new System.Windows.Forms.Timer(this.components);
            this.lblTimeoutPrompt = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.grpChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkittles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHaribo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuavers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWalkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCocaCola)).BeginInit();
            this.grpCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChoice
            // 
            this.grpChoice.Controls.Add(this.pbBin);
            this.grpChoice.Controls.Add(this.btnCheckout);
            this.grpChoice.Controls.Add(this.lstItemsPicked);
            this.grpChoice.Controls.Add(this.lblTotal);
            this.grpChoice.Controls.Add(this.btnHaribo);
            this.grpChoice.Controls.Add(this.btnSkittles);
            this.grpChoice.Controls.Add(this.btnWalkers);
            this.grpChoice.Controls.Add(this.btnQuavers);
            this.grpChoice.Controls.Add(this.btnFanta);
            this.grpChoice.Controls.Add(this.btnCocaCola);
            this.grpChoice.Controls.Add(this.pbFanta);
            this.grpChoice.Controls.Add(this.pbSkittles);
            this.grpChoice.Controls.Add(this.pbHaribo);
            this.grpChoice.Controls.Add(this.pbQuavers);
            this.grpChoice.Controls.Add(this.pbWalkers);
            this.grpChoice.Controls.Add(this.pbCocaCola);
            this.grpChoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpChoice.Location = new System.Drawing.Point(11, 33);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Size = new System.Drawing.Size(436, 464);
            this.grpChoice.TabIndex = 0;
            this.grpChoice.TabStop = false;
            this.grpChoice.Text = "Pick From The Available Choices";
            // 
            // pbBin
            // 
            this.pbBin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBin.Image = ((System.Drawing.Image)(resources.GetObject("pbBin.Image")));
            this.pbBin.Location = new System.Drawing.Point(363, 379);
            this.pbBin.Name = "pbBin";
            this.pbBin.Size = new System.Drawing.Size(65, 73);
            this.pbBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBin.TabIndex = 14;
            this.pbBin.TabStop = false;
            this.pbBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbBin_DragDrop);
            this.pbBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbBin_DragEnter);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(254, 425);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(103, 27);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lstItemsPicked
            // 
            this.lstItemsPicked.FormattingEnabled = true;
            this.lstItemsPicked.ItemHeight = 17;
            this.lstItemsPicked.Location = new System.Drawing.Point(254, 24);
            this.lstItemsPicked.Name = "lstItemsPicked";
            this.lstItemsPicked.Size = new System.Drawing.Size(174, 344);
            this.lstItemsPicked.TabIndex = 13;
            this.lstItemsPicked.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstItemsPicked_MouseDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(268, 405);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: £0.00";
            // 
            // btnHaribo
            // 
            this.btnHaribo.BackColor = System.Drawing.Color.White;
            this.btnHaribo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHaribo.Location = new System.Drawing.Point(126, 130);
            this.btnHaribo.Name = "btnHaribo";
            this.btnHaribo.Size = new System.Drawing.Size(116, 23);
            this.btnHaribo.TabIndex = 12;
            this.btnHaribo.Text = "Haribo   £2.50";
            this.btnHaribo.UseVisualStyleBackColor = false;
            this.btnHaribo.Click += new System.EventHandler(this.btnHaribo_Click);
            // 
            // btnSkittles
            // 
            this.btnSkittles.BackColor = System.Drawing.Color.White;
            this.btnSkittles.Location = new System.Drawing.Point(4, 130);
            this.btnSkittles.Name = "btnSkittles";
            this.btnSkittles.Size = new System.Drawing.Size(116, 23);
            this.btnSkittles.TabIndex = 11;
            this.btnSkittles.Text = "Skittles   £3.00";
            this.btnSkittles.UseVisualStyleBackColor = false;
            this.btnSkittles.Click += new System.EventHandler(this.btnSkittles_Click);
            // 
            // btnWalkers
            // 
            this.btnWalkers.BackColor = System.Drawing.Color.White;
            this.btnWalkers.Location = new System.Drawing.Point(127, 278);
            this.btnWalkers.Name = "btnWalkers";
            this.btnWalkers.Size = new System.Drawing.Size(116, 23);
            this.btnWalkers.TabIndex = 10;
            this.btnWalkers.Text = "Walkers   £1.50";
            this.btnWalkers.UseVisualStyleBackColor = false;
            this.btnWalkers.Click += new System.EventHandler(this.btnWalkers_Click);
            // 
            // btnQuavers
            // 
            this.btnQuavers.BackColor = System.Drawing.Color.White;
            this.btnQuavers.Location = new System.Drawing.Point(6, 278);
            this.btnQuavers.Name = "btnQuavers";
            this.btnQuavers.Size = new System.Drawing.Size(116, 23);
            this.btnQuavers.TabIndex = 9;
            this.btnQuavers.Text = "Quavers   £1.50";
            this.btnQuavers.UseVisualStyleBackColor = false;
            this.btnQuavers.Click += new System.EventHandler(this.btnQuavers_Click);
            // 
            // btnFanta
            // 
            this.btnFanta.BackColor = System.Drawing.Color.White;
            this.btnFanta.Location = new System.Drawing.Point(128, 429);
            this.btnFanta.Name = "btnFanta";
            this.btnFanta.Size = new System.Drawing.Size(116, 23);
            this.btnFanta.TabIndex = 8;
            this.btnFanta.Text = "Fanta   £3.00";
            this.btnFanta.UseVisualStyleBackColor = false;
            this.btnFanta.Click += new System.EventHandler(this.btnFanta_Click);
            // 
            // btnCocaCola
            // 
            this.btnCocaCola.BackColor = System.Drawing.Color.White;
            this.btnCocaCola.Location = new System.Drawing.Point(7, 429);
            this.btnCocaCola.Name = "btnCocaCola";
            this.btnCocaCola.Size = new System.Drawing.Size(116, 23);
            this.btnCocaCola.TabIndex = 7;
            this.btnCocaCola.Text = "CocaCola   £3.00";
            this.btnCocaCola.UseVisualStyleBackColor = false;
            this.btnCocaCola.Click += new System.EventHandler(this.btnCocaCola_Click);
            // 
            // pbFanta
            // 
            this.pbFanta.BackColor = System.Drawing.Color.White;
            this.pbFanta.Image = ((System.Drawing.Image)(resources.GetObject("pbFanta.Image")));
            this.pbFanta.Location = new System.Drawing.Point(128, 323);
            this.pbFanta.Name = "pbFanta";
            this.pbFanta.Size = new System.Drawing.Size(115, 100);
            this.pbFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFanta.TabIndex = 6;
            this.pbFanta.TabStop = false;
            // 
            // pbSkittles
            // 
            this.pbSkittles.BackColor = System.Drawing.Color.White;
            this.pbSkittles.Image = ((System.Drawing.Image)(resources.GetObject("pbSkittles.Image")));
            this.pbSkittles.Location = new System.Drawing.Point(6, 24);
            this.pbSkittles.Name = "pbSkittles";
            this.pbSkittles.Size = new System.Drawing.Size(115, 100);
            this.pbSkittles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSkittles.TabIndex = 5;
            this.pbSkittles.TabStop = false;
            // 
            // pbHaribo
            // 
            this.pbHaribo.BackColor = System.Drawing.Color.White;
            this.pbHaribo.Image = ((System.Drawing.Image)(resources.GetObject("pbHaribo.Image")));
            this.pbHaribo.Location = new System.Drawing.Point(127, 24);
            this.pbHaribo.Name = "pbHaribo";
            this.pbHaribo.Size = new System.Drawing.Size(115, 100);
            this.pbHaribo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHaribo.TabIndex = 1;
            this.pbHaribo.TabStop = false;
            // 
            // pbQuavers
            // 
            this.pbQuavers.BackColor = System.Drawing.Color.White;
            this.pbQuavers.Image = ((System.Drawing.Image)(resources.GetObject("pbQuavers.Image")));
            this.pbQuavers.Location = new System.Drawing.Point(6, 172);
            this.pbQuavers.Name = "pbQuavers";
            this.pbQuavers.Size = new System.Drawing.Size(115, 100);
            this.pbQuavers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuavers.TabIndex = 4;
            this.pbQuavers.TabStop = false;
            // 
            // pbWalkers
            // 
            this.pbWalkers.BackColor = System.Drawing.Color.White;
            this.pbWalkers.Image = ((System.Drawing.Image)(resources.GetObject("pbWalkers.Image")));
            this.pbWalkers.Location = new System.Drawing.Point(127, 172);
            this.pbWalkers.Name = "pbWalkers";
            this.pbWalkers.Size = new System.Drawing.Size(115, 100);
            this.pbWalkers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWalkers.TabIndex = 2;
            this.pbWalkers.TabStop = false;
            // 
            // pbCocaCola
            // 
            this.pbCocaCola.BackColor = System.Drawing.Color.White;
            this.pbCocaCola.Image = ((System.Drawing.Image)(resources.GetObject("pbCocaCola.Image")));
            this.pbCocaCola.Location = new System.Drawing.Point(7, 323);
            this.pbCocaCola.Name = "pbCocaCola";
            this.pbCocaCola.Size = new System.Drawing.Size(115, 100);
            this.pbCocaCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCocaCola.TabIndex = 3;
            this.pbCocaCola.TabStop = false;
            // 
            // grpCheckout
            // 
            this.grpCheckout.Controls.Add(this.lblLastAction);
            this.grpCheckout.Controls.Add(this.btnCancel);
            this.grpCheckout.Controls.Add(this.btnCoinslot);
            this.grpCheckout.Controls.Add(this.btn2Pound);
            this.grpCheckout.Controls.Add(this.btn10Pence);
            this.grpCheckout.Controls.Add(this.btn20Pence);
            this.grpCheckout.Controls.Add(this.btn5Pound);
            this.grpCheckout.Controls.Add(this.btn10Pound);
            this.grpCheckout.Controls.Add(this.btn50Pence);
            this.grpCheckout.Controls.Add(this.btn20Pound);
            this.grpCheckout.Controls.Add(this.btn1Pound);
            this.grpCheckout.Enabled = false;
            this.grpCheckout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCheckout.Location = new System.Drawing.Point(11, 503);
            this.grpCheckout.Name = "grpCheckout";
            this.grpCheckout.Size = new System.Drawing.Size(436, 354);
            this.grpCheckout.TabIndex = 0;
            this.grpCheckout.TabStop = false;
            this.grpCheckout.Text = "Checkout";
            // 
            // lblLastAction
            // 
            this.lblLastAction.AutoSize = true;
            this.lblLastAction.Location = new System.Drawing.Point(7, 323);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(118, 17);
            this.lblLastAction.TabIndex = 1;
            this.lblLastAction.Text = "Last Action: None";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(284, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCoinslot
            // 
            this.btnCoinslot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoinslot.BackgroundImage")));
            this.btnCoinslot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoinslot.Location = new System.Drawing.Point(286, 93);
            this.btnCoinslot.Name = "btnCoinslot";
            this.btnCoinslot.Size = new System.Drawing.Size(114, 76);
            this.btnCoinslot.TabIndex = 8;
            this.btnCoinslot.UseVisualStyleBackColor = true;
            this.btnCoinslot.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnCoinslot_DragDrop);
            this.btnCoinslot.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnCoinslot_DragEnter);
            // 
            // btn2Pound
            // 
            this.btn2Pound.BackColor = System.Drawing.Color.White;
            this.btn2Pound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2Pound.BackgroundImage")));
            this.btn2Pound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2Pound.Location = new System.Drawing.Point(123, 106);
            this.btn2Pound.Name = "btn2Pound";
            this.btn2Pound.Size = new System.Drawing.Size(110, 63);
            this.btn2Pound.TabIndex = 7;
            this.btn2Pound.Tag = "2";
            this.btn2Pound.Text = "£2";
            this.btn2Pound.UseVisualStyleBackColor = false;
            this.btn2Pound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn2Pound_MouseDown);
            // 
            // btn10Pence
            // 
            this.btn10Pence.BackColor = System.Drawing.Color.White;
            this.btn10Pence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn10Pence.BackgroundImage")));
            this.btn10Pence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn10Pence.Location = new System.Drawing.Point(123, 244);
            this.btn10Pence.Name = "btn10Pence";
            this.btn10Pence.Size = new System.Drawing.Size(110, 63);
            this.btn10Pence.TabIndex = 6;
            this.btn10Pence.Tag = "0.10";
            this.btn10Pence.Text = "10p";
            this.btn10Pence.UseVisualStyleBackColor = false;
            this.btn10Pence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn10Pence_MouseDown);
            // 
            // btn20Pence
            // 
            this.btn20Pence.BackColor = System.Drawing.Color.White;
            this.btn20Pence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn20Pence.BackgroundImage")));
            this.btn20Pence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn20Pence.Location = new System.Drawing.Point(7, 244);
            this.btn20Pence.Name = "btn20Pence";
            this.btn20Pence.Size = new System.Drawing.Size(110, 63);
            this.btn20Pence.TabIndex = 5;
            this.btn20Pence.Tag = "0.20";
            this.btn20Pence.Text = "20p";
            this.btn20Pence.UseVisualStyleBackColor = false;
            this.btn20Pence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn20Pence_MouseDown);
            // 
            // btn5Pound
            // 
            this.btn5Pound.BackColor = System.Drawing.Color.White;
            this.btn5Pound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5Pound.BackgroundImage")));
            this.btn5Pound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5Pound.Location = new System.Drawing.Point(7, 106);
            this.btn5Pound.Name = "btn5Pound";
            this.btn5Pound.Size = new System.Drawing.Size(110, 63);
            this.btn5Pound.TabIndex = 4;
            this.btn5Pound.Tag = "5";
            this.btn5Pound.Text = "£5";
            this.btn5Pound.UseVisualStyleBackColor = false;
            this.btn5Pound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn5Pound_MouseDown);
            // 
            // btn10Pound
            // 
            this.btn10Pound.BackColor = System.Drawing.Color.White;
            this.btn10Pound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn10Pound.BackgroundImage")));
            this.btn10Pound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn10Pound.Location = new System.Drawing.Point(123, 37);
            this.btn10Pound.Name = "btn10Pound";
            this.btn10Pound.Size = new System.Drawing.Size(110, 63);
            this.btn10Pound.TabIndex = 3;
            this.btn10Pound.Tag = "10";
            this.btn10Pound.Text = "£10";
            this.btn10Pound.UseVisualStyleBackColor = false;
            this.btn10Pound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn10Pound_MouseDown);
            // 
            // btn50Pence
            // 
            this.btn50Pence.BackColor = System.Drawing.Color.White;
            this.btn50Pence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn50Pence.BackgroundImage")));
            this.btn50Pence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn50Pence.Location = new System.Drawing.Point(123, 175);
            this.btn50Pence.Name = "btn50Pence";
            this.btn50Pence.Size = new System.Drawing.Size(110, 63);
            this.btn50Pence.TabIndex = 2;
            this.btn50Pence.Tag = "0.50";
            this.btn50Pence.Text = "50p";
            this.btn50Pence.UseVisualStyleBackColor = false;
            this.btn50Pence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn50Pence_MouseDown);
            // 
            // btn20Pound
            // 
            this.btn20Pound.BackColor = System.Drawing.Color.White;
            this.btn20Pound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn20Pound.BackgroundImage")));
            this.btn20Pound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn20Pound.Location = new System.Drawing.Point(7, 37);
            this.btn20Pound.Name = "btn20Pound";
            this.btn20Pound.Size = new System.Drawing.Size(110, 63);
            this.btn20Pound.TabIndex = 1;
            this.btn20Pound.Tag = "20";
            this.btn20Pound.Text = "£20";
            this.btn20Pound.UseVisualStyleBackColor = false;
            this.btn20Pound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn20Pound_MouseDown);
            // 
            // btn1Pound
            // 
            this.btn1Pound.BackColor = System.Drawing.Color.White;
            this.btn1Pound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1Pound.BackgroundImage")));
            this.btn1Pound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1Pound.Location = new System.Drawing.Point(7, 175);
            this.btn1Pound.Name = "btn1Pound";
            this.btn1Pound.Size = new System.Drawing.Size(110, 63);
            this.btn1Pound.TabIndex = 0;
            this.btn1Pound.Tag = "1";
            this.btn1Pound.Text = "£1";
            this.btn1Pound.UseVisualStyleBackColor = false;
            this.btn1Pound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1Pound_MouseDown);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // tmrEnd
            // 
            this.tmrEnd.Enabled = true;
            this.tmrEnd.Interval = 1000;
            this.tmrEnd.Tick += new System.EventHandler(this.tmrEnd_Tick);
            // 
            // lblTimeoutPrompt
            // 
            this.lblTimeoutPrompt.AutoSize = true;
            this.lblTimeoutPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeoutPrompt.Location = new System.Drawing.Point(11, 9);
            this.lblTimeoutPrompt.Name = "lblTimeoutPrompt";
            this.lblTimeoutPrompt.Size = new System.Drawing.Size(0, 21);
            this.lblTimeoutPrompt.TabIndex = 11;
            this.lblTimeoutPrompt.Visible = false;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrompt.Location = new System.Drawing.Point(11, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(135, 21);
            this.lblPrompt.TabIndex = 12;
            this.lblPrompt.Text = "Timeout Prompt";
            this.lblPrompt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(459, 869);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblTimeoutPrompt);
            this.Controls.Add(this.grpCheckout);
            this.Controls.Add(this.grpChoice);
            this.Name = "Form1";
            this.Text = "VendingMachine(30043859)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpChoice.ResumeLayout(false);
            this.grpChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkittles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHaribo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuavers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWalkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCocaCola)).EndInit();
            this.grpCheckout.ResumeLayout(false);
            this.grpCheckout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpChoice;
        private GroupBox grpCheckout;
        private PictureBox pbFanta;
        private PictureBox pbSkittles;
        private PictureBox pbHaribo;
        private PictureBox pbQuavers;
        private PictureBox pbWalkers;
        private PictureBox pbCocaCola;
        private Button btnHaribo;
        private Button btnSkittles;
        private Button btnWalkers;
        private Button btnQuavers;
        private Button btnFanta;
        private Button btnCocaCola;
        private Button btnCoinslot;
        private Button btn2Pound;
        private Button btn10Pence;
        private Button btn20Pence;
        private Button btn5Pound;
        private Button btn10Pound;
        private Button btn50Pence;
        private Button btn20Pound;
        private Button btn1Pound;
        private Label lblTotal;
        private ListBox lstItemsPicked;
        private Button btnCheckout;
        private Button btnCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pbBin;
        private Label lblLastAction;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Timer tmrEnd;
        private Label lblTimeoutPrompt;
        private Label lblPrompt;
    }
}