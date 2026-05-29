namespace Graphs
{
    partial class Graph
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lblInput = new Label();
            txtInput = new TextBox();
            btnSort = new Button();
            lblSelection = new Label();
            rtbSelection = new RichTextBox();
            lblInsertion = new Label();
            rtbInsertion = new RichTextBox();
            lblQuick = new Label();
            rtbQuick = new RichTextBox();
            lblHeap = new Label();
            rtbHeap = new RichTextBox();
            lblRadix = new Label();
            rtbRadix = new RichTextBox();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            formsPlot1.Location = new Point(3, 6);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(833, 511);
            formsPlot1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(840, 550);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(formsPlot1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Benchmark";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblInput);
            tabPage2.Controls.Add(txtInput);
            tabPage2.Controls.Add(btnSort);
            tabPage2.Controls.Add(lblSelection);
            tabPage2.Controls.Add(rtbSelection);
            tabPage2.Controls.Add(lblInsertion);
            tabPage2.Controls.Add(rtbInsertion);
            tabPage2.Controls.Add(lblQuick);
            tabPage2.Controls.Add(rtbQuick);
            tabPage2.Controls.Add(lblHeap);
            tabPage2.Controls.Add(rtbHeap);
            tabPage2.Controls.Add(lblRadix);
            tabPage2.Controls.Add(rtbRadix);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(832, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Controll";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblInput
            // 
            lblInput.Location = new Point(15, 15);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(150, 25);
            lblInput.TabIndex = 0;
            lblInput.Text = "Введите список чисел:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(170, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(450, 27);
            txtInput.TabIndex = 0;
            txtInput.Text = "746, 530, 8, 1, 5, 69, 7, 283, 91, 150, 66, 320, 1, 9, 4";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(635, 10);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(150, 30);
            btnSort.TabIndex = 1;
            btnSort.Text = "Сортировать";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblSelection
            // 
            lblSelection.Location = new Point(15, 55);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(380, 23);
            lblSelection.TabIndex = 2;
            lblSelection.Text = "Метод выбора:";
            // 
            // rtbSelection
            // 
            rtbSelection.Location = new Point(15, 80);
            rtbSelection.Name = "rtbSelection";
            rtbSelection.Size = new Size(380, 110);
            rtbSelection.TabIndex = 3;
            rtbSelection.Text = "";
            // 
            // lblInsertion
            // 
            lblInsertion.Location = new Point(415, 55);
            lblInsertion.Name = "lblInsertion";
            lblInsertion.Size = new Size(380, 23);
            lblInsertion.TabIndex = 4;
            lblInsertion.Text = "Метод вставок:";
            // 
            // rtbInsertion
            // 
            rtbInsertion.Location = new Point(415, 80);
            rtbInsertion.Name = "rtbInsertion";
            rtbInsertion.Size = new Size(380, 110);
            rtbInsertion.TabIndex = 5;
            rtbInsertion.Text = "";
            // 
            // lblQuick
            // 
            lblQuick.Location = new Point(15, 205);
            lblQuick.Name = "lblQuick";
            lblQuick.Size = new Size(380, 23);
            lblQuick.TabIndex = 6;
            lblQuick.Text = "Быстрая сортировка:";
            // 
            // rtbQuick
            // 
            rtbQuick.Location = new Point(15, 230);
            rtbQuick.Name = "rtbQuick";
            rtbQuick.Size = new Size(380, 110);
            rtbQuick.TabIndex = 7;
            rtbQuick.Text = "";
            // 
            // lblHeap
            // 
            lblHeap.Location = new Point(415, 205);
            lblHeap.Name = "lblHeap";
            lblHeap.Size = new Size(380, 23);
            lblHeap.TabIndex = 8;
            lblHeap.Text = "Пирамидальная:";
            // 
            // rtbHeap
            // 
            rtbHeap.Location = new Point(415, 230);
            rtbHeap.Name = "rtbHeap";
            rtbHeap.Size = new Size(380, 110);
            rtbHeap.TabIndex = 9;
            rtbHeap.Text = "";
            // 
            // lblRadix
            // 
            lblRadix.Location = new Point(15, 355);
            lblRadix.Name = "lblRadix";
            lblRadix.Size = new Size(780, 23);
            lblRadix.TabIndex = 10;
            lblRadix.Text = "Поразрядная сортировка:";
            // 
            // rtbRadix
            // 
            rtbRadix.Location = new Point(15, 380);
            rtbRadix.Name = "rtbRadix";
            rtbRadix.Size = new Size(780, 110);
            rtbRadix.TabIndex = 11;
            rtbRadix.Text = "";
            // 
            // Graphs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 550);
            Controls.Add(tabControl);
            Name = "Graphs";
            Text = "График";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;

        // Объявление новых элементов управления
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.RichTextBox rtbSelection;
        private System.Windows.Forms.Label lblInsertion;
        private System.Windows.Forms.RichTextBox rtbInsertion;
        private System.Windows.Forms.Label lblQuick;
        private System.Windows.Forms.RichTextBox rtbQuick;
        private System.Windows.Forms.Label lblHeap;
        private System.Windows.Forms.RichTextBox rtbHeap;
        private System.Windows.Forms.Label lblRadix;
        private System.Windows.Forms.RichTextBox rtbRadix;
    }
}
