namespace HarcosokApplication
{
    partial class Form1
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
            this.label_HarcosLetrehozas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.letrehozasButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kepessegHozzaadasButton = new System.Windows.Forms.Button();
            this.leirasLabel = new System.Windows.Forms.Label();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.label_KepessegNev = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.label_Harcos = new System.Windows.Forms.Label();
            this.label_Kepesseg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modositasButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.kepessegekLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekleirasasLabel = new System.Windows.Forms.Label();
            this.kepessegekLabel = new System.Windows.Forms.Label();
            this.harcosokLabel = new System.Windows.Forms.Label();
            this.regUserekLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_HarcosLetrehozas
            // 
            this.label_HarcosLetrehozas.AutoSize = true;
            this.label_HarcosLetrehozas.Location = new System.Drawing.Point(30, 13);
            this.label_HarcosLetrehozas.Name = "label_HarcosLetrehozas";
            this.label_HarcosLetrehozas.Size = new System.Drawing.Size(102, 13);
            this.label_HarcosLetrehozas.TabIndex = 0;
            this.label_HarcosLetrehozas.Text = "Harcos Létrehozása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(78, 50);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(220, 20);
            this.harcosNeveTextBox.TabIndex = 2;
            this.harcosNeveTextBox.Text = "harcosNeveTextBox";
            // 
            // letrehozasButton
            // 
            this.letrehozasButton.Location = new System.Drawing.Point(349, 50);
            this.letrehozasButton.Name = "letrehozasButton";
            this.letrehozasButton.Size = new System.Drawing.Size(75, 23);
            this.letrehozasButton.TabIndex = 3;
            this.letrehozasButton.Text = "Létrehozás";
            this.letrehozasButton.UseVisualStyleBackColor = true;
            this.letrehozasButton.Click += new System.EventHandler(this.letrehozasButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kepessegHozzaadasButton);
            this.groupBox1.Controls.Add(this.leirasLabel);
            this.groupBox1.Controls.Add(this.kepessegNeveTextBox);
            this.groupBox1.Controls.Add(this.label_KepessegNev);
            this.groupBox1.Controls.Add(this.leirasTextBox);
            this.groupBox1.Controls.Add(this.hasznaloComboBox);
            this.groupBox1.Controls.Add(this.label_Harcos);
            this.groupBox1.Controls.Add(this.label_Kepesseg);
            this.groupBox1.Location = new System.Drawing.Point(-11, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // kepessegHozzaadasButton
            // 
            this.kepessegHozzaadasButton.Location = new System.Drawing.Point(315, 76);
            this.kepessegHozzaadasButton.Name = "kepessegHozzaadasButton";
            this.kepessegHozzaadasButton.Size = new System.Drawing.Size(75, 23);
            this.kepessegHozzaadasButton.TabIndex = 7;
            this.kepessegHozzaadasButton.Text = "Hozzáadás";
            this.kepessegHozzaadasButton.UseVisualStyleBackColor = true;
            this.kepessegHozzaadasButton.Click += new System.EventHandler(this.kepessegHozzaadasButton_Click);
            // 
            // leirasLabel
            // 
            this.leirasLabel.AutoSize = true;
            this.leirasLabel.Location = new System.Drawing.Point(405, 14);
            this.leirasLabel.Name = "leirasLabel";
            this.leirasLabel.Size = new System.Drawing.Size(40, 13);
            this.leirasLabel.TabIndex = 6;
            this.leirasLabel.Text = "Leírás:";
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(109, 79);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(200, 20);
            this.kepessegNeveTextBox.TabIndex = 5;
            this.kepessegNeveTextBox.Text = "kepessegNeveTextBox";
            // 
            // label_KepessegNev
            // 
            this.label_KepessegNev.AutoSize = true;
            this.label_KepessegNev.Location = new System.Drawing.Point(30, 79);
            this.label_KepessegNev.Name = "label_KepessegNev";
            this.label_KepessegNev.Size = new System.Drawing.Size(57, 13);
            this.label_KepessegNev.TabIndex = 4;
            this.label_KepessegNev.Text = "Kepesseg:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(408, 30);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(270, 62);
            this.leirasTextBox.TabIndex = 3;
            this.leirasTextBox.Text = "leirasTextBox";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(109, 44);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(121, 21);
            this.hasznaloComboBox.TabIndex = 2;
            this.hasznaloComboBox.Text = "hasznaloComboBox";
            // 
            // label_Harcos
            // 
            this.label_Harcos.AutoSize = true;
            this.label_Harcos.Location = new System.Drawing.Point(27, 47);
            this.label_Harcos.Name = "label_Harcos";
            this.label_Harcos.Size = new System.Drawing.Size(44, 13);
            this.label_Harcos.TabIndex = 1;
            this.label_Harcos.Text = "Harcos:";
            // 
            // label_Kepesseg
            // 
            this.label_Kepesseg.AutoSize = true;
            this.label_Kepesseg.Location = new System.Drawing.Point(24, 20);
            this.label_Kepesseg.Name = "label_Kepesseg";
            this.label_Kepesseg.Size = new System.Drawing.Size(114, 13);
            this.label_Kepesseg.TabIndex = 0;
            this.label_Kepesseg.Text = "Képesség hozzáadása";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modositasButton);
            this.groupBox2.Controls.Add(this.torlesButton);
            this.groupBox2.Controls.Add(this.kepessegekLeirasaTextBox);
            this.groupBox2.Controls.Add(this.kepessegekListBox);
            this.groupBox2.Controls.Add(this.harcosokListBox);
            this.groupBox2.Controls.Add(this.kepessegekleirasasLabel);
            this.groupBox2.Controls.Add(this.kepessegekLabel);
            this.groupBox2.Controls.Add(this.harcosokLabel);
            this.groupBox2.Location = new System.Drawing.Point(-11, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 405);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // modositasButton
            // 
            this.modositasButton.Location = new System.Drawing.Point(727, 237);
            this.modositasButton.Name = "modositasButton";
            this.modositasButton.Size = new System.Drawing.Size(75, 23);
            this.modositasButton.TabIndex = 7;
            this.modositasButton.Text = "Módosít";
            this.modositasButton.UseVisualStyleBackColor = true;
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(387, 370);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(75, 23);
            this.torlesButton.TabIndex = 6;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            // 
            // kepessegekLeirasaTextBox
            // 
            this.kepessegekLeirasaTextBox.Location = new System.Drawing.Point(567, 87);
            this.kepessegekLeirasaTextBox.Multiline = true;
            this.kepessegekLeirasaTextBox.Name = "kepessegekLeirasaTextBox";
            this.kepessegekLeirasaTextBox.Size = new System.Drawing.Size(261, 126);
            this.kepessegekLeirasaTextBox.TabIndex = 5;
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(353, 87);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(178, 277);
            this.kepessegekListBox.TabIndex = 4;
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(47, 87);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(183, 277);
            this.harcosokListBox.TabIndex = 3;
            // 
            // kepessegekleirasasLabel
            // 
            this.kepessegekleirasasLabel.AutoSize = true;
            this.kepessegekleirasasLabel.Location = new System.Drawing.Point(564, 34);
            this.kepessegekleirasasLabel.Name = "kepessegekleirasasLabel";
            this.kepessegekleirasasLabel.Size = new System.Drawing.Size(89, 13);
            this.kepessegekleirasasLabel.TabIndex = 2;
            this.kepessegekleirasasLabel.Text = "Képesség leírása";
            // 
            // kepessegekLabel
            // 
            this.kepessegekLabel.AutoSize = true;
            this.kepessegekLabel.Location = new System.Drawing.Point(350, 34);
            this.kepessegekLabel.Name = "kepessegekLabel";
            this.kepessegekLabel.Size = new System.Drawing.Size(65, 13);
            this.kepessegekLabel.TabIndex = 1;
            this.kepessegekLabel.Text = "Képességei:";
            // 
            // harcosokLabel
            // 
            this.harcosokLabel.AutoSize = true;
            this.harcosokLabel.Location = new System.Drawing.Point(44, 34);
            this.harcosokLabel.Name = "harcosokLabel";
            this.harcosokLabel.Size = new System.Drawing.Size(56, 13);
            this.harcosokLabel.TabIndex = 0;
            this.harcosokLabel.Text = "Harcosok:";
            // 
            // regUserekLabel
            // 
            this.regUserekLabel.AutoSize = true;
            this.regUserekLabel.Location = new System.Drawing.Point(484, 56);
            this.regUserekLabel.Name = "regUserekLabel";
            this.regUserekLabel.Size = new System.Drawing.Size(35, 13);
            this.regUserekLabel.TabIndex = 6;
            this.regUserekLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 601);
            this.Controls.Add(this.regUserekLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.letrehozasButton);
            this.Controls.Add(this.harcosNeveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_HarcosLetrehozas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HarcosLetrehozas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Button letrehozasButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label_Harcos;
        private System.Windows.Forms.Label label_Kepesseg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        public System.Windows.Forms.Label label_KepessegNev;
        private System.Windows.Forms.Button modositasButton;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.TextBox kepessegekLeirasaTextBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.Label kepessegekleirasasLabel;
        private System.Windows.Forms.Label kepessegekLabel;
        private System.Windows.Forms.Label harcosokLabel;
        private System.Windows.Forms.Label leirasLabel;
        private System.Windows.Forms.Label regUserekLabel;
        private System.Windows.Forms.Button kepessegHozzaadasButton;
    }
}

