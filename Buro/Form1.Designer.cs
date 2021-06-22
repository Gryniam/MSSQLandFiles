
namespace Buro
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddColorBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddPlaceBox = new System.Windows.Forms.TextBox();
            this.AddTimeBox = new System.Windows.Forms.TextBox();
            this.AddWeightBox = new System.Windows.Forms.TextBox();
            this.AddNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchDbButton = new System.Windows.Forms.Button();
            this.ParametrBox = new System.Windows.Forms.TextBox();
            this.SearchVBox = new System.Windows.Forms.ComboBox();
            this.SearchId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FotoForChange = new System.Windows.Forms.TextBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DelId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ChangeFotoButton = new System.Windows.Forms.Button();
            this.UpdPlace = new System.Windows.Forms.TextBox();
            this.UPDButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.UpdTime = new System.Windows.Forms.TextBox();
            this.UpdWeight = new System.Windows.Forms.TextBox();
            this.UpdColor = new System.Windows.Forms.TextBox();
            this.UpdName = new System.Windows.Forms.TextBox();
            this.RedId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(772, 315);
            this.table.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.AddColorBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddPlaceBox);
            this.panel1.Controls.Add(this.AddTimeBox);
            this.panel1.Controls.Add(this.AddWeightBox);
            this.panel1.Controls.Add(this.AddNameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 206);
            this.panel1.TabIndex = 1;
            // 
            // AddColorBox
            // 
            this.AddColorBox.FormattingEnabled = true;
            this.AddColorBox.Items.AddRange(new object[] {
            "Червоний",
            "Синій",
            "Коричневий",
            "Помаранчевий",
            "Сірий",
            "Чорний",
            "Білий",
            "Зелений",
            "Голубий",
            "Жовтий",
            "Золотий",
            "Срібний"});
            this.AddColorBox.Location = new System.Drawing.Point(10, 60);
            this.AddColorBox.Name = "AddColorBox";
            this.AddColorBox.Size = new System.Drawing.Size(140, 21);
            this.AddColorBox.TabIndex = 8;
            this.AddColorBox.Click += new System.EventHandler(this.AddNameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 130);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ім\'я предмету\r\n\r\n\r\nКолір\r\n\r\nВага(кг)\r\n\r\nЧас знахідки\r\n\r\nМісце знахідки";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Додати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Зображення";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPlaceBox
            // 
            this.AddPlaceBox.Location = new System.Drawing.Point(10, 139);
            this.AddPlaceBox.Name = "AddPlaceBox";
            this.AddPlaceBox.Size = new System.Drawing.Size(140, 20);
            this.AddPlaceBox.TabIndex = 5;
            this.AddPlaceBox.Click += new System.EventHandler(this.AddNameBox_TextChanged);
            this.AddPlaceBox.TextChanged += new System.EventHandler(this.AddNameBox_TextChanged);
            // 
            // AddTimeBox
            // 
            this.AddTimeBox.Location = new System.Drawing.Point(10, 113);
            this.AddTimeBox.Name = "AddTimeBox";
            this.AddTimeBox.Size = new System.Drawing.Size(140, 20);
            this.AddTimeBox.TabIndex = 4;
            this.AddTimeBox.Click += new System.EventHandler(this.AddNameBox_TextChanged);
            this.AddTimeBox.TextChanged += new System.EventHandler(this.AddNameBox_TextChanged);
            // 
            // AddWeightBox
            // 
            this.AddWeightBox.Location = new System.Drawing.Point(10, 87);
            this.AddWeightBox.Name = "AddWeightBox";
            this.AddWeightBox.Size = new System.Drawing.Size(140, 20);
            this.AddWeightBox.TabIndex = 3;
            this.AddWeightBox.Click += new System.EventHandler(this.AddNameBox_TextChanged);
            // 
            // AddNameBox
            // 
            this.AddNameBox.Location = new System.Drawing.Point(10, 24);
            this.AddNameBox.Name = "AddNameBox";
            this.AddNameBox.Size = new System.Drawing.Size(140, 20);
            this.AddNameBox.TabIndex = 1;
            this.AddNameBox.TextChanged += new System.EventHandler(this.AddNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДОДАВАННЯ ПРЕДМЕТУ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.SearchDbButton);
            this.panel2.Controls.Add(this.ParametrBox);
            this.panel2.Controls.Add(this.SearchVBox);
            this.panel2.Controls.Add(this.SearchId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.SearchImage);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(260, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 206);
            this.panel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 52);
            this.label8.TabIndex = 12;
            this.label8.Text = "Поле\r\n\r\n\r\nПараметр";
            // 
            // SearchDbButton
            // 
            this.SearchDbButton.Location = new System.Drawing.Point(197, 3);
            this.SearchDbButton.Name = "SearchDbButton";
            this.SearchDbButton.Size = new System.Drawing.Size(66, 23);
            this.SearchDbButton.TabIndex = 11;
            this.SearchDbButton.Text = "Search";
            this.SearchDbButton.UseVisualStyleBackColor = true;
            this.SearchDbButton.Click += new System.EventHandler(this.SearchDbButton_Click);
            // 
            // ParametrBox
            // 
            this.ParametrBox.Location = new System.Drawing.Point(5, 73);
            this.ParametrBox.Name = "ParametrBox";
            this.ParametrBox.Size = new System.Drawing.Size(120, 20);
            this.ParametrBox.TabIndex = 10;
            this.ParametrBox.TextChanged += new System.EventHandler(this.ParametrBox_TextChanged);
            // 
            // SearchVBox
            // 
            this.SearchVBox.FormattingEnabled = true;
            this.SearchVBox.Items.AddRange(new object[] {
            "Ім\'я предмету",
            "Колір",
            "Вага",
            "Час знахідки",
            "Місце знахідки"});
            this.SearchVBox.Location = new System.Drawing.Point(5, 30);
            this.SearchVBox.Name = "SearchVBox";
            this.SearchVBox.Size = new System.Drawing.Size(121, 21);
            this.SearchVBox.TabIndex = 9;
            this.SearchVBox.SelectedIndexChanged += new System.EventHandler(this.SearchVBox_SelectedIndexChanged);
            // 
            // SearchId
            // 
            this.SearchId.Location = new System.Drawing.Point(4, 131);
            this.SearchId.Name = "SearchId";
            this.SearchId.Size = new System.Drawing.Size(127, 20);
            this.SearchId.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 7;
            // 
            // SearchImage
            // 
            this.SearchImage.Location = new System.Drawing.Point(188, 164);
            this.SearchImage.Name = "SearchImage";
            this.SearchImage.Size = new System.Drawing.Size(75, 37);
            this.SearchImage.TabIndex = 4;
            this.SearchImage.Text = "Search";
            this.SearchImage.UseVisualStyleBackColor = true;
            this.SearchImage.Click += new System.EventHandler(this.SearchImage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ПОШУК ФОТО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ПОШУК ПРЕДМЕТУ В БАЗІ ДАНИХ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.FotoForChange);
            this.panel3.Controls.Add(this.PathBox);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.DelId);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(532, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 206);
            this.panel3.TabIndex = 3;
            // 
            // FotoForChange
            // 
            this.FotoForChange.Enabled = false;
            this.FotoForChange.Location = new System.Drawing.Point(136, 179);
            this.FotoForChange.Name = "FotoForChange";
            this.FotoForChange.Size = new System.Drawing.Size(100, 20);
            this.FotoForChange.TabIndex = 5;
            this.FotoForChange.Visible = false;
            // 
            // PathBox
            // 
            this.PathBox.Enabled = false;
            this.PathBox.Location = new System.Drawing.Point(6, 180);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(100, 20);
            this.PathBox.TabIndex = 4;
            this.PathBox.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(138, 24);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 29);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID";
            // 
            // DelId
            // 
            this.DelId.Location = new System.Drawing.Point(5, 31);
            this.DelId.Name = "DelId";
            this.DelId.Size = new System.Drawing.Size(100, 20);
            this.DelId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ВИДАЛЕННЯ ПРЕДМЕТУ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "РЕДАГУВАННЯ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(790, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 293);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(793, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(793, 309);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect DB";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(874, 309);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.ChangeFotoButton);
            this.panel4.Controls.Add(this.UpdPlace);
            this.panel4.Controls.Add(this.UPDButton);
            this.panel4.Controls.Add(this.OkButton);
            this.panel4.Controls.Add(this.UpdTime);
            this.panel4.Controls.Add(this.UpdWeight);
            this.panel4.Controls.Add(this.UpdColor);
            this.panel4.Controls.Add(this.UpdName);
            this.panel4.Controls.Add(this.RedId);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(793, 355);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 182);
            this.panel4.TabIndex = 5;
            // 
            // ChangeFotoButton
            // 
            this.ChangeFotoButton.Location = new System.Drawing.Point(96, 26);
            this.ChangeFotoButton.Name = "ChangeFotoButton";
            this.ChangeFotoButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeFotoButton.TabIndex = 13;
            this.ChangeFotoButton.Text = "Change foto";
            this.ChangeFotoButton.UseVisualStyleBackColor = true;
            this.ChangeFotoButton.Click += new System.EventHandler(this.ChangeFotoButton_Click);
            // 
            // UpdPlace
            // 
            this.UpdPlace.Location = new System.Drawing.Point(5, 158);
            this.UpdPlace.Name = "UpdPlace";
            this.UpdPlace.Size = new System.Drawing.Size(126, 20);
            this.UpdPlace.TabIndex = 12;
            // 
            // UPDButton
            // 
            this.UPDButton.Location = new System.Drawing.Point(174, 26);
            this.UPDButton.Name = "UPDButton";
            this.UPDButton.Size = new System.Drawing.Size(75, 23);
            this.UPDButton.TabIndex = 11;
            this.UPDButton.Text = "UPDATE";
            this.UPDButton.UseVisualStyleBackColor = true;
            this.UPDButton.Click += new System.EventHandler(this.UPDButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(57, 26);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(35, 23);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // UpdTime
            // 
            this.UpdTime.Location = new System.Drawing.Point(6, 134);
            this.UpdTime.Name = "UpdTime";
            this.UpdTime.Size = new System.Drawing.Size(126, 20);
            this.UpdTime.TabIndex = 9;
            // 
            // UpdWeight
            // 
            this.UpdWeight.Location = new System.Drawing.Point(6, 108);
            this.UpdWeight.Name = "UpdWeight";
            this.UpdWeight.Size = new System.Drawing.Size(126, 20);
            this.UpdWeight.TabIndex = 8;
            // 
            // UpdColor
            // 
            this.UpdColor.Location = new System.Drawing.Point(6, 81);
            this.UpdColor.Name = "UpdColor";
            this.UpdColor.Size = new System.Drawing.Size(126, 20);
            this.UpdColor.TabIndex = 7;
            // 
            // UpdName
            // 
            this.UpdName.Location = new System.Drawing.Point(6, 55);
            this.UpdName.Name = "UpdName";
            this.UpdName.Size = new System.Drawing.Size(126, 20);
            this.UpdName.TabIndex = 6;
            // 
            // RedId
            // 
            this.RedId.Location = new System.Drawing.Point(6, 26);
            this.RedId.Name = "RedId";
            this.RedId.Size = new System.Drawing.Size(45, 20);
            this.RedId.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 117);
            this.label13.TabIndex = 14;
            this.label13.Text = "Назва предмету\r\n\r\nКолір\r\n\r\nВага\r\n\r\nЧас знахідки\r\n\r\nМісце знахідки";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(955, 309);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 8;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 549);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Бюро знахідок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AddPlaceBox;
        private System.Windows.Forms.TextBox AddTimeBox;
        private System.Windows.Forms.TextBox AddWeightBox;
        private System.Windows.Forms.TextBox AddNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox AddColorBox;
        private System.Windows.Forms.Button SearchImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SearchDbButton;
        private System.Windows.Forms.TextBox ParametrBox;
        private System.Windows.Forms.ComboBox SearchVBox;
        private System.Windows.Forms.TextBox SearchId;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DelId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox UpdTime;
        private System.Windows.Forms.TextBox UpdWeight;
        private System.Windows.Forms.TextBox UpdColor;
        private System.Windows.Forms.TextBox UpdName;
        private System.Windows.Forms.TextBox RedId;
        private System.Windows.Forms.Button UPDButton;
        private System.Windows.Forms.TextBox UpdPlace;
        private System.Windows.Forms.Button ChangeFotoButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.TextBox FotoForChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button DisconnectButton;
    }
}

