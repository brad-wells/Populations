namespace CitiesVer2
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.InsertPopTxtBox = new System.Windows.Forms.TextBox();
            this.InsertCityTxtBox = new System.Windows.Forms.TextBox();
            this.EditPopTxtBox = new System.Windows.Forms.TextBox();
            this.EditCityTxtBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CitiesListBox = new System.Windows.Forms.ListBox();
            this.ViewOptionButton = new System.Windows.Forms.Button();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.FormatOptionButton = new System.Windows.Forms.Button();
            this.SearchOptionButton = new System.Windows.Forms.Button();
            this.DeleteOptionButton = new System.Windows.Forms.Button();
            this.InsertOption = new System.Windows.Forms.Button();
            this.ModifyOptionButton = new System.Windows.Forms.Button();
            this.AddOptionButton = new System.Windows.Forms.Button();
            this.SearchButtonTwo = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.InstLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PopLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.OptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.PopLabel);
            this.MainPanel.Controls.Add(this.CityLabel);
            this.MainPanel.Controls.Add(this.InstLabel);
            this.MainPanel.Controls.Add(this.ViewButton);
            this.MainPanel.Controls.Add(this.SearchButtonTwo);
            this.MainPanel.Controls.Add(this.SearchListBox);
            this.MainPanel.Controls.Add(this.InsertPopTxtBox);
            this.MainPanel.Controls.Add(this.InsertCityTxtBox);
            this.MainPanel.Controls.Add(this.EditPopTxtBox);
            this.MainPanel.Controls.Add(this.EditCityTxtBox);
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.InsertButton);
            this.MainPanel.Controls.Add(this.EditButton);
            this.MainPanel.Controls.Add(this.AddButton);
            this.MainPanel.Controls.Add(this.CitiesListBox);
            this.MainPanel.Location = new System.Drawing.Point(104, 8);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainPanel.Size = new System.Drawing.Size(502, 363);
            this.MainPanel.TabIndex = 0;
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.ItemHeight = 16;
            this.SearchListBox.Location = new System.Drawing.Point(225, 37);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(228, 148);
            this.SearchListBox.TabIndex = 10;
            // 
            // InsertPopTxtBox
            // 
            this.InsertPopTxtBox.Location = new System.Drawing.Point(340, 269);
            this.InsertPopTxtBox.Name = "InsertPopTxtBox";
            this.InsertPopTxtBox.Size = new System.Drawing.Size(119, 22);
            this.InsertPopTxtBox.TabIndex = 8;
            // 
            // InsertCityTxtBox
            // 
            this.InsertCityTxtBox.Location = new System.Drawing.Point(340, 241);
            this.InsertCityTxtBox.Name = "InsertCityTxtBox";
            this.InsertCityTxtBox.Size = new System.Drawing.Size(119, 22);
            this.InsertCityTxtBox.TabIndex = 7;
            // 
            // EditPopTxtBox
            // 
            this.EditPopTxtBox.Location = new System.Drawing.Point(340, 269);
            this.EditPopTxtBox.Name = "EditPopTxtBox";
            this.EditPopTxtBox.Size = new System.Drawing.Size(119, 22);
            this.EditPopTxtBox.TabIndex = 6;
            // 
            // EditCityTxtBox
            // 
            this.EditCityTxtBox.Location = new System.Drawing.Point(340, 239);
            this.EditCityTxtBox.Name = "EditCityTxtBox";
            this.EditCityTxtBox.Size = new System.Drawing.Size(119, 22);
            this.EditCityTxtBox.TabIndex = 5;
            // 
            // DeleteButton
            // 
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteButton.Location = new System.Drawing.Point(371, 307);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 38);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete City";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InsertButton.Location = new System.Drawing.Point(371, 308);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(88, 38);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert City";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EditButton.Location = new System.Drawing.Point(371, 307);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(88, 38);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit City";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddButton.Location = new System.Drawing.Point(371, 302);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add City";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CitiesListBox
            // 
            this.CitiesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CitiesListBox.FormattingEnabled = true;
            this.CitiesListBox.ItemHeight = 16;
            this.CitiesListBox.Location = new System.Drawing.Point(225, 37);
            this.CitiesListBox.Name = "CitiesListBox";
            this.CitiesListBox.Size = new System.Drawing.Size(234, 196);
            this.CitiesListBox.TabIndex = 0;
            this.CitiesListBox.SelectedIndexChanged += new System.EventHandler(this.CitiesListBox_SelectedIndexChanged);
            // 
            // ViewOptionButton
            // 
            this.ViewOptionButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ViewOptionButton.Location = new System.Drawing.Point(12, 115);
            this.ViewOptionButton.Name = "ViewOptionButton";
            this.ViewOptionButton.Size = new System.Drawing.Size(75, 33);
            this.ViewOptionButton.TabIndex = 9;
            this.ViewOptionButton.Text = "View ";
            this.ViewOptionButton.UseVisualStyleBackColor = true;
            this.ViewOptionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionPanel
            // 
            this.OptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.OptionPanel.Controls.Add(this.FormatOptionButton);
            this.OptionPanel.Controls.Add(this.SearchOptionButton);
            this.OptionPanel.Controls.Add(this.DeleteOptionButton);
            this.OptionPanel.Controls.Add(this.InsertOption);
            this.OptionPanel.Controls.Add(this.ModifyOptionButton);
            this.OptionPanel.Controls.Add(this.AddOptionButton);
            this.OptionPanel.Controls.Add(this.ViewOptionButton);
            this.OptionPanel.Location = new System.Drawing.Point(11, 8);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(95, 363);
            this.OptionPanel.TabIndex = 1;
            // 
            // FormatOptionButton
            // 
            this.FormatOptionButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatOptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormatOptionButton.Location = new System.Drawing.Point(12, 273);
            this.FormatOptionButton.Name = "FormatOptionButton";
            this.FormatOptionButton.Size = new System.Drawing.Size(75, 33);
            this.FormatOptionButton.TabIndex = 15;
            this.FormatOptionButton.Text = "Format";
            this.FormatOptionButton.UseVisualStyleBackColor = true;
            this.FormatOptionButton.Click += new System.EventHandler(this.FormatOptionButton_Click);
            // 
            // SearchOptionButton
            // 
            this.SearchOptionButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SearchOptionButton.Location = new System.Drawing.Point(12, 234);
            this.SearchOptionButton.Name = "SearchOptionButton";
            this.SearchOptionButton.Size = new System.Drawing.Size(75, 33);
            this.SearchOptionButton.TabIndex = 14;
            this.SearchOptionButton.Text = "Search";
            this.SearchOptionButton.UseVisualStyleBackColor = true;
            this.SearchOptionButton.Click += new System.EventHandler(this.SearchOptionButton_Click);
            // 
            // DeleteOptionButton
            // 
            this.DeleteOptionButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteOptionButton.Location = new System.Drawing.Point(12, 193);
            this.DeleteOptionButton.Name = "DeleteOptionButton";
            this.DeleteOptionButton.Size = new System.Drawing.Size(75, 33);
            this.DeleteOptionButton.TabIndex = 13;
            this.DeleteOptionButton.Text = "Delete";
            this.DeleteOptionButton.UseVisualStyleBackColor = true;
            this.DeleteOptionButton.Click += new System.EventHandler(this.DeleteOptionButton_Click);
            // 
            // InsertOption
            // 
            this.InsertOption.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InsertOption.Location = new System.Drawing.Point(12, 154);
            this.InsertOption.Name = "InsertOption";
            this.InsertOption.Size = new System.Drawing.Size(75, 33);
            this.InsertOption.TabIndex = 12;
            this.InsertOption.Text = "Insert";
            this.InsertOption.UseVisualStyleBackColor = true;
            this.InsertOption.Click += new System.EventHandler(this.InsertOption_Click);
            // 
            // ModifyOptionButton
            // 
            this.ModifyOptionButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyOptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModifyOptionButton.Location = new System.Drawing.Point(12, 76);
            this.ModifyOptionButton.Name = "ModifyOptionButton";
            this.ModifyOptionButton.Size = new System.Drawing.Size(75, 33);
            this.ModifyOptionButton.TabIndex = 11;
            this.ModifyOptionButton.Text = "Modify";
            this.ModifyOptionButton.UseVisualStyleBackColor = true;
            this.ModifyOptionButton.Click += new System.EventHandler(this.ModifyOptionButton_Click);
            // 
            // AddOptionButton
            // 
            this.AddOptionButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddOptionButton.Location = new System.Drawing.Point(12, 37);
            this.AddOptionButton.Name = "AddOptionButton";
            this.AddOptionButton.Size = new System.Drawing.Size(75, 33);
            this.AddOptionButton.TabIndex = 10;
            this.AddOptionButton.Text = "Add";
            this.AddOptionButton.UseVisualStyleBackColor = true;
            this.AddOptionButton.Click += new System.EventHandler(this.AddOptionButton_Click);
            // 
            // SearchButtonTwo
            // 
            this.SearchButtonTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SearchButtonTwo.Location = new System.Drawing.Point(371, 307);
            this.SearchButtonTwo.Name = "SearchButtonTwo";
            this.SearchButtonTwo.Size = new System.Drawing.Size(88, 38);
            this.SearchButtonTwo.TabIndex = 11;
            this.SearchButtonTwo.Text = "Search";
            this.SearchButtonTwo.UseVisualStyleBackColor = true;
            this.SearchButtonTwo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ViewButton
            // 
            this.ViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ViewButton.Location = new System.Drawing.Point(371, 302);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(88, 38);
            this.ViewButton.TabIndex = 12;
            this.ViewButton.Text = "View cities";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // InstLabel
            // 
            this.InstLabel.AutoSize = true;
            this.InstLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstLabel.ForeColor = System.Drawing.Color.White;
            this.InstLabel.Location = new System.Drawing.Point(19, 37);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(0, 24);
            this.InstLabel.TabIndex = 13;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.Color.White;
            this.CityLabel.Location = new System.Drawing.Point(241, 237);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(39, 24);
            this.CityLabel.TabIndex = 14;
            this.CityLabel.Text = "CITY:";
            // 
            // PopLabel
            // 
            this.PopLabel.AutoSize = true;
            this.PopLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopLabel.ForeColor = System.Drawing.Color.White;
            this.PopLabel.Location = new System.Drawing.Point(241, 269);
            this.PopLabel.Name = "PopLabel";
            this.PopLabel.Size = new System.Drawing.Size(93, 24);
            this.PopLabel.TabIndex = 15;
            this.PopLabel.Text = "POPULATION:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(19, 269);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 24);
            this.ErrorLabel.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 377);
            this.Controls.Add(this.OptionPanel);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cities and Populations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.OptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox EditPopTxtBox;
        private System.Windows.Forms.TextBox EditCityTxtBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CitiesListBox;
        private System.Windows.Forms.TextBox InsertPopTxtBox;
        private System.Windows.Forms.TextBox InsertCityTxtBox;
        private System.Windows.Forms.Button ViewOptionButton;
        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.Button AddOptionButton;
        private System.Windows.Forms.Button ModifyOptionButton;
        private System.Windows.Forms.Button InsertOption;
        private System.Windows.Forms.Button DeleteOptionButton;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.Button SearchOptionButton;
        private System.Windows.Forms.Button FormatOptionButton;
        private System.Windows.Forms.Button SearchButtonTwo;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.Label PopLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

