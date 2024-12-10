namespace Pizza_Project
{
    partial class frmPizzaMenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1menue = new System.Windows.Forms.Label();
            this.rd_small = new System.Windows.Forms.RadioButton();
            this.rd_large = new System.Windows.Forms.RadioButton();
            this.rd_medium = new System.Windows.Forms.RadioButton();
            this.gp_size = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.rdThink = new System.Windows.Forms.RadioButton();
            this.gp_where = new System.Windows.Forms.GroupBox();
            this.rdEat_in = new System.Windows.Forms.RadioButton();
            this.rdTake_Out = new System.Windows.Forms.RadioButton();
            this.gp_Toppings = new System.Windows.Forms.GroupBox();
            this.chk_peper = new System.Windows.Forms.CheckBox();
            this.chk_mushroom = new System.Windows.Forms.CheckBox();
            this.chk_olives = new System.Windows.Forms.CheckBox();
            this.chk_Tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_Onion = new System.Windows.Forms.CheckBox();
            this.chk_cheese = new System.Windows.Forms.CheckBox();
            this.btnOrderPizaa = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Topping = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_WhereToEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_CurstType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gp_OrderSammary = new System.Windows.Forms.GroupBox();
            this.lb_size = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gp_size.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gp_where.SuspendLayout();
            this.gp_Toppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gp_OrderSammary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1menue
            // 
            this.lb1menue.AutoSize = true;
            this.lb1menue.BackColor = System.Drawing.Color.White;
            this.lb1menue.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1menue.ForeColor = System.Drawing.Color.Goldenrod;
            this.lb1menue.Location = new System.Drawing.Point(243, 0);
            this.lb1menue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1menue.Name = "lb1menue";
            this.lb1menue.Size = new System.Drawing.Size(690, 105);
            this.lb1menue.TabIndex = 1;
            this.lb1menue.Text = "Make Your Pizza";
            // 
            // rd_small
            // 
            this.rd_small.AutoSize = true;
            this.rd_small.Location = new System.Drawing.Point(22, 29);
            this.rd_small.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rd_small.Name = "rd_small";
            this.rd_small.Size = new System.Drawing.Size(96, 32);
            this.rd_small.TabIndex = 2;
            this.rd_small.TabStop = true;
            this.rd_small.Tag = "17";
            this.rd_small.Text = "Small";
            this.rd_small.UseVisualStyleBackColor = true;
            this.rd_small.CheckedChanged += new System.EventHandler(this.rd_small_CheckedChanged);
            // 
            // rd_large
            // 
            this.rd_large.AutoSize = true;
            this.rd_large.Location = new System.Drawing.Point(22, 143);
            this.rd_large.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rd_large.Name = "rd_large";
            this.rd_large.Size = new System.Drawing.Size(98, 32);
            this.rd_large.TabIndex = 3;
            this.rd_large.TabStop = true;
            this.rd_large.Tag = "30";
            this.rd_large.Text = "Large";
            this.rd_large.UseVisualStyleBackColor = true;
            this.rd_large.CheckedChanged += new System.EventHandler(this.rd_large_CheckedChanged);
            // 
            // rd_medium
            // 
            this.rd_medium.AutoSize = true;
            this.rd_medium.ForeColor = System.Drawing.Color.Olive;
            this.rd_medium.Location = new System.Drawing.Point(22, 78);
            this.rd_medium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rd_medium.Name = "rd_medium";
            this.rd_medium.Size = new System.Drawing.Size(126, 32);
            this.rd_medium.TabIndex = 4;
            this.rd_medium.TabStop = true;
            this.rd_medium.Tag = "20";
            this.rd_medium.Text = "Medium";
            this.rd_medium.UseVisualStyleBackColor = true;
            this.rd_medium.CheckedChanged += new System.EventHandler(this.rd_medium_CheckedChanged);
            // 
            // gp_size
            // 
            this.gp_size.Controls.Add(this.groupBox1);
            this.gp_size.Controls.Add(this.rd_small);
            this.gp_size.Controls.Add(this.rd_medium);
            this.gp_size.Controls.Add(this.rd_large);
            this.gp_size.Font = new System.Drawing.Font("Microsoft JhengHei Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_size.ForeColor = System.Drawing.Color.Olive;
            this.gp_size.Location = new System.Drawing.Point(32, 165);
            this.gp_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_size.Name = "gp_size";
            this.gp_size.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_size.Size = new System.Drawing.Size(207, 208);
            this.gp_size.TabIndex = 5;
            this.gp_size.TabStop = false;
            this.gp_size.Text = "Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(207, 15);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 29);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 32);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 78);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 32);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 143);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 32);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Large";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // gpCrustType
            // 
            this.gpCrustType.Controls.Add(this.rdThin);
            this.gpCrustType.Controls.Add(this.rdThink);
            this.gpCrustType.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCrustType.ForeColor = System.Drawing.Color.Chocolate;
            this.gpCrustType.Location = new System.Drawing.Point(32, 398);
            this.gpCrustType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpCrustType.Size = new System.Drawing.Size(207, 140);
            this.gpCrustType.TabIndex = 6;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Text = "Crust Type";
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(22, 29);
            this.rdThin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(161, 32);
            this.rdThin.TabIndex = 2;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "0";
            this.rdThin.Text = "Think Curst";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // rdThink
            // 
            this.rdThink.AutoSize = true;
            this.rdThink.Location = new System.Drawing.Point(22, 78);
            this.rdThink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdThink.Name = "rdThink";
            this.rdThink.Size = new System.Drawing.Size(159, 32);
            this.rdThink.TabIndex = 4;
            this.rdThink.TabStop = true;
            this.rdThink.Tag = "7";
            this.rdThink.Text = "Thick Curst";
            this.rdThink.UseVisualStyleBackColor = true;
            this.rdThink.CheckedChanged += new System.EventHandler(this.rdThink_CheckedChanged);
            // 
            // gp_where
            // 
            this.gp_where.Controls.Add(this.rdEat_in);
            this.gp_where.Controls.Add(this.rdTake_Out);
            this.gp_where.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_where.ForeColor = System.Drawing.Color.OliveDrab;
            this.gp_where.Location = new System.Drawing.Point(336, 463);
            this.gp_where.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_where.Name = "gp_where";
            this.gp_where.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_where.Size = new System.Drawing.Size(333, 75);
            this.gp_where.TabIndex = 7;
            this.gp_where.TabStop = false;
            this.gp_where.Text = "Where To Eat";
            // 
            // rdEat_in
            // 
            this.rdEat_in.AutoSize = true;
            this.rdEat_in.Location = new System.Drawing.Point(22, 29);
            this.rdEat_in.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdEat_in.Name = "rdEat_in";
            this.rdEat_in.Size = new System.Drawing.Size(99, 32);
            this.rdEat_in.TabIndex = 2;
            this.rdEat_in.TabStop = true;
            this.rdEat_in.Tag = "0";
            this.rdEat_in.Text = "Eat In";
            this.rdEat_in.UseVisualStyleBackColor = true;
            this.rdEat_in.CheckedChanged += new System.EventHandler(this.rdEat_in_CheckedChanged);
            // 
            // rdTake_Out
            // 
            this.rdTake_Out.AutoSize = true;
            this.rdTake_Out.Location = new System.Drawing.Point(206, 29);
            this.rdTake_Out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTake_Out.Name = "rdTake_Out";
            this.rdTake_Out.Size = new System.Drawing.Size(134, 32);
            this.rdTake_Out.TabIndex = 4;
            this.rdTake_Out.TabStop = true;
            this.rdTake_Out.Tag = "0";
            this.rdTake_Out.Text = "Take Out";
            this.rdTake_Out.UseVisualStyleBackColor = true;
            this.rdTake_Out.CheckedChanged += new System.EventHandler(this.rdTake_Out_CheckedChanged);
            // 
            // gp_Toppings
            // 
            this.gp_Toppings.Controls.Add(this.chk_peper);
            this.gp_Toppings.Controls.Add(this.chk_mushroom);
            this.gp_Toppings.Controls.Add(this.chk_olives);
            this.gp_Toppings.Controls.Add(this.chk_Tomatoes);
            this.gp_Toppings.Controls.Add(this.chk_Onion);
            this.gp_Toppings.Controls.Add(this.chk_cheese);
            this.gp_Toppings.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_Toppings.ForeColor = System.Drawing.Color.Olive;
            this.gp_Toppings.Location = new System.Drawing.Point(336, 145);
            this.gp_Toppings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_Toppings.Name = "gp_Toppings";
            this.gp_Toppings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_Toppings.Size = new System.Drawing.Size(411, 240);
            this.gp_Toppings.TabIndex = 8;
            this.gp_Toppings.TabStop = false;
            this.gp_Toppings.Text = "Toppings";
            // 
            // chk_peper
            // 
            this.chk_peper.AutoSize = true;
            this.chk_peper.Location = new System.Drawing.Point(224, 162);
            this.chk_peper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_peper.Name = "chk_peper";
            this.chk_peper.Size = new System.Drawing.Size(174, 32);
            this.chk_peper.TabIndex = 5;
            this.chk_peper.Tag = "3";
            this.chk_peper.Text = "Green Peper";
            this.chk_peper.UseVisualStyleBackColor = true;
            this.chk_peper.CheckedChanged += new System.EventHandler(this.chk_peper_CheckedChanged);
            // 
            // chk_mushroom
            // 
            this.chk_mushroom.AutoSize = true;
            this.chk_mushroom.Location = new System.Drawing.Point(224, 100);
            this.chk_mushroom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_mushroom.Name = "chk_mushroom";
            this.chk_mushroom.Size = new System.Drawing.Size(165, 32);
            this.chk_mushroom.TabIndex = 4;
            this.chk_mushroom.Tag = "5";
            this.chk_mushroom.Text = "Mushrooms";
            this.chk_mushroom.UseVisualStyleBackColor = true;
            this.chk_mushroom.CheckedChanged += new System.EventHandler(this.chk_mushroom_CheckedChanged);
            // 
            // chk_olives
            // 
            this.chk_olives.AutoSize = true;
            this.chk_olives.Location = new System.Drawing.Point(224, 38);
            this.chk_olives.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_olives.Name = "chk_olives";
            this.chk_olives.Size = new System.Drawing.Size(104, 32);
            this.chk_olives.TabIndex = 3;
            this.chk_olives.Tag = "2";
            this.chk_olives.Text = "Olives";
            this.chk_olives.UseVisualStyleBackColor = true;
            this.chk_olives.CheckedChanged += new System.EventHandler(this.chk_olives_CheckedChanged);
            // 
            // chk_Tomatoes
            // 
            this.chk_Tomatoes.AutoSize = true;
            this.chk_Tomatoes.Location = new System.Drawing.Point(22, 162);
            this.chk_Tomatoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_Tomatoes.Name = "chk_Tomatoes";
            this.chk_Tomatoes.Size = new System.Drawing.Size(142, 32);
            this.chk_Tomatoes.TabIndex = 2;
            this.chk_Tomatoes.Tag = "2";
            this.chk_Tomatoes.Text = "Tomatoes";
            this.chk_Tomatoes.UseVisualStyleBackColor = true;
            this.chk_Tomatoes.CheckedChanged += new System.EventHandler(this.chk_Tomatoes_CheckedChanged);
            // 
            // chk_Onion
            // 
            this.chk_Onion.AutoSize = true;
            this.chk_Onion.Location = new System.Drawing.Point(21, 100);
            this.chk_Onion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_Onion.Name = "chk_Onion";
            this.chk_Onion.Size = new System.Drawing.Size(105, 32);
            this.chk_Onion.TabIndex = 1;
            this.chk_Onion.Tag = "2";
            this.chk_Onion.Text = "Onion";
            this.chk_Onion.UseVisualStyleBackColor = true;
            this.chk_Onion.CheckedChanged += new System.EventHandler(this.chk_Onion_CheckedChanged);
            // 
            // chk_cheese
            // 
            this.chk_cheese.AutoSize = true;
            this.chk_cheese.Location = new System.Drawing.Point(22, 38);
            this.chk_cheese.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_cheese.Name = "chk_cheese";
            this.chk_cheese.Size = new System.Drawing.Size(172, 32);
            this.chk_cheese.TabIndex = 0;
            this.chk_cheese.Tag = "2";
            this.chk_cheese.Text = "Extra chesse";
            this.chk_cheese.UseVisualStyleBackColor = true;
            this.chk_cheese.CheckedChanged += new System.EventHandler(this.chk_cheese_CheckedChanged);
            // 
            // btnOrderPizaa
            // 
            this.btnOrderPizaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizaa.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnOrderPizaa.Location = new System.Drawing.Point(279, 606);
            this.btnOrderPizaa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrderPizaa.Name = "btnOrderPizaa";
            this.btnOrderPizaa.Size = new System.Drawing.Size(192, 68);
            this.btnOrderPizaa.TabIndex = 9;
            this.btnOrderPizaa.Text = "Order Pizaa";
            this.btnOrderPizaa.UseVisualStyleBackColor = true;
            this.btnOrderPizaa.Click += new System.EventHandler(this.btnOrderPizaa_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnResetForm.Location = new System.Drawing.Point(526, 606);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(192, 68);
            this.btnResetForm.TabIndex = 10;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 692);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, -195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Size";
            // 
            // lb_Topping
            // 
            this.lb_Topping.Location = new System.Drawing.Point(120, 41);
            this.lb_Topping.Name = "lb_Topping";
            this.lb_Topping.Size = new System.Drawing.Size(314, 86);
            this.lb_Topping.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, -97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Where To Eat";
            // 
            // lb_WhereToEat
            // 
            this.lb_WhereToEat.AutoSize = true;
            this.lb_WhereToEat.Location = new System.Drawing.Point(174, 127);
            this.lb_WhereToEat.Name = "lb_WhereToEat";
            this.lb_WhereToEat.Size = new System.Drawing.Size(0, 28);
            this.lb_WhereToEat.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "toppings :";
            // 
            // lb_CurstType
            // 
            this.lb_CurstType.AutoSize = true;
            this.lb_CurstType.Location = new System.Drawing.Point(172, 186);
            this.lb_CurstType.Name = "lb_CurstType";
            this.lb_CurstType.Size = new System.Drawing.Size(0, 28);
            this.lb_CurstType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Curst Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Price :";
            // 
            // gp_OrderSammary
            // 
            this.gp_OrderSammary.Controls.Add(this.lb_size);
            this.gp_OrderSammary.Controls.Add(this.label2);
            this.gp_OrderSammary.Controls.Add(this.lb_TotalPrice);
            this.gp_OrderSammary.Controls.Add(this.label9);
            this.gp_OrderSammary.Controls.Add(this.lb_CurstType);
            this.gp_OrderSammary.Controls.Add(this.label5);
            this.gp_OrderSammary.Controls.Add(this.lb_WhereToEat);
            this.gp_OrderSammary.Controls.Add(this.label8);
            this.gp_OrderSammary.Controls.Add(this.lb_Topping);
            this.gp_OrderSammary.Controls.Add(this.label1);
            this.gp_OrderSammary.Controls.Add(this.label7);
            this.gp_OrderSammary.Controls.Add(this.label3);
            this.gp_OrderSammary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_OrderSammary.ForeColor = System.Drawing.Color.Coral;
            this.gp_OrderSammary.Location = new System.Drawing.Point(754, 243);
            this.gp_OrderSammary.Name = "gp_OrderSammary";
            this.gp_OrderSammary.Size = new System.Drawing.Size(446, 366);
            this.gp_OrderSammary.TabIndex = 17;
            this.gp_OrderSammary.TabStop = false;
            this.gp_OrderSammary.Text = "Order Summary";
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Location = new System.Drawing.Point(188, 249);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(0, 28);
            this.lb_size.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Size :";
            // 
            // lb_TotalPrice
            // 
            this.lb_TotalPrice.AutoSize = true;
            this.lb_TotalPrice.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalPrice.ForeColor = System.Drawing.Color.Crimson;
            this.lb_TotalPrice.Location = new System.Drawing.Point(188, 312);
            this.lb_TotalPrice.Name = "lb_TotalPrice";
            this.lb_TotalPrice.Size = new System.Drawing.Size(0, 48);
            this.lb_TotalPrice.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "where To Eat :";
            // 
            // frmPizzaMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gp_OrderSammary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizaa);
            this.Controls.Add(this.gp_Toppings);
            this.Controls.Add(this.gp_where);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.gp_size);
            this.Controls.Add(this.lb1menue);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPizzaMenue";
            this.Text = "Pizza Menue";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gp_size.ResumeLayout(false);
            this.gp_size.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gp_where.ResumeLayout(false);
            this.gp_where.PerformLayout();
            this.gp_Toppings.ResumeLayout(false);
            this.gp_Toppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gp_OrderSammary.ResumeLayout(false);
            this.gp_OrderSammary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb1menue;
        private System.Windows.Forms.RadioButton rd_small;
        private System.Windows.Forms.RadioButton rd_large;
        private System.Windows.Forms.RadioButton rd_medium;
        private System.Windows.Forms.GroupBox gp_size;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rdThink;
        private System.Windows.Forms.GroupBox gp_where;
        private System.Windows.Forms.RadioButton rdEat_in;
        private System.Windows.Forms.RadioButton rdTake_Out;
        private System.Windows.Forms.GroupBox gp_Toppings;
        private System.Windows.Forms.CheckBox chk_peper;
        private System.Windows.Forms.CheckBox chk_mushroom;
        private System.Windows.Forms.CheckBox chk_olives;
        private System.Windows.Forms.CheckBox chk_Tomatoes;
        private System.Windows.Forms.CheckBox chk_Onion;
        private System.Windows.Forms.CheckBox chk_cheese;
        private System.Windows.Forms.Button btnOrderPizaa;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Topping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_WhereToEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_CurstType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gp_OrderSammary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_TotalPrice;
        private System.Windows.Forms.Label lb_size;
        private System.Windows.Forms.Label label2;
    }
}