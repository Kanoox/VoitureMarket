namespace Bibliotheque_cars
{
    partial class Form2
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
            listBox_marque = new ListBox();
            label1 = new Label();
            listBox_type = new ListBox();
            label2 = new Label();
            listBox_vehdispo = new ListBox();
            label3 = new Label();
            button_affichermarque = new Button();
            carburantBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            anneeBox = new TextBox();
            label7 = new Label();
            powerBox = new TextBox();
            label8 = new Label();
            transmissionBox = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // listBox_marque
            // 
            listBox_marque.FormattingEnabled = true;
            listBox_marque.ItemHeight = 15;
            listBox_marque.Location = new Point(30, 63);
            listBox_marque.Name = "listBox_marque";
            listBox_marque.Size = new Size(169, 229);
            listBox_marque.TabIndex = 0;
            listBox_marque.SelectedIndexChanged += listBox_marque_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 1;
            label1.Text = "Liste des marques";
            // 
            // listBox_type
            // 
            listBox_type.FormattingEnabled = true;
            listBox_type.ItemHeight = 15;
            listBox_type.Location = new Point(205, 63);
            listBox_type.Name = "listBox_type";
            listBox_type.Size = new Size(101, 229);
            listBox_type.TabIndex = 2;
            listBox_type.SelectedIndexChanged += listBox_type_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 38);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 3;
            label2.Text = "Type ";
            // 
            // listBox_vehdispo
            // 
            listBox_vehdispo.FormattingEnabled = true;
            listBox_vehdispo.ItemHeight = 15;
            listBox_vehdispo.Location = new Point(364, 63);
            listBox_vehdispo.Name = "listBox_vehdispo";
            listBox_vehdispo.Size = new Size(129, 229);
            listBox_vehdispo.TabIndex = 4;
            listBox_vehdispo.SelectedIndexChanged += listBox_vehdispo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(326, 38);
            label3.Name = "label3";
            label3.Size = new Size(231, 22);
            label3.TabIndex = 5;
            label3.Text = "Liste des véhicules disponible";
            // 
            // button_affichermarque
            // 
            button_affichermarque.Location = new Point(50, 298);
            button_affichermarque.Name = "button_affichermarque";
            button_affichermarque.Size = new Size(125, 53);
            button_affichermarque.TabIndex = 6;
            button_affichermarque.Text = "Afficher les marques";
            button_affichermarque.UseVisualStyleBackColor = true;
            button_affichermarque.Click += button_affichermarque_Click;
            // 
            // carburantBox
            // 
            carburantBox.Location = new Point(574, 176);
            carburantBox.Name = "carburantBox";
            carburantBox.Size = new Size(109, 23);
            carburantBox.TabIndex = 7;
            carburantBox.TextChanged += carburantBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(574, 77);
            label4.Name = "label4";
            label4.Size = new Size(236, 22);
            label4.TabIndex = 8;
            label4.Text = "Description du véhicule choisi";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 158);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "Carburant";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 211);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Année";
            // 
            // anneeBox
            // 
            anneeBox.Location = new Point(574, 229);
            anneeBox.Name = "anneeBox";
            anneeBox.Size = new Size(109, 23);
            anneeBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(701, 211);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 13;
            label7.Text = "Puissance";
            // 
            // powerBox
            // 
            powerBox.Location = new Point(701, 229);
            powerBox.Name = "powerBox";
            powerBox.Size = new Size(109, 23);
            powerBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(701, 158);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 15;
            label8.Text = "Transmission";
            // 
            // transmissionBox
            // 
            transmissionBox.Location = new Point(701, 176);
            transmissionBox.Name = "transmissionBox";
            transmissionBox.Size = new Size(109, 23);
            transmissionBox.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(574, 114);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 16;
            label9.Text = "Modèle choisi :";
            label9.Click += label9_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 451);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(transmissionBox);
            Controls.Add(label7);
            Controls.Add(powerBox);
            Controls.Add(label6);
            Controls.Add(anneeBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(carburantBox);
            Controls.Add(button_affichermarque);
            Controls.Add(label3);
            Controls.Add(listBox_vehdispo);
            Controls.Add(label2);
            Controls.Add(listBox_type);
            Controls.Add(label1);
            Controls.Add(listBox_marque);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_marque;
        private Label label1;
        private ListBox listBox_type;
        private Label label2;
        private ListBox listBox_vehdispo;
        private Label label3;
        private Button button_affichermarque;
        private TextBox carburantBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox anneeBox;
        private Label label7;
        private TextBox powerBox;
        private Label label8;
        private TextBox transmissionBox;
        private Label label9;
    }
}