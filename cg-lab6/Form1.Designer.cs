namespace cg_lab6
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
            graphicPanel = new Panel();
            groupBuild = new GroupBox();
            buttonDraw = new Button();
            comboFigures = new ComboBox();
            groupProjection = new GroupBox();
            radioPerspectiveIsometric = new RadioButton();
            radioPerspectiveCentral = new RadioButton();
            groupRotate = new GroupBox();
            buttonRotateAxes = new Button();
            inputAngle = new TextBox();
            label1 = new Label();
            comboAxes = new ComboBox();
            groupShift = new GroupBox();
            buttonShiftCoords = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            inputShiftZ = new TextBox();
            inputShiftY = new TextBox();
            inputShiftX = new TextBox();
            label2 = new Label();
            groupScale = new GroupBox();
            buttonScaleCoords = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            inputScaleZ = new TextBox();
            inputScaleY = new TextBox();
            inputScaleX = new TextBox();
            label9 = new Label();
            groupBuild.SuspendLayout();
            groupProjection.SuspendLayout();
            groupRotate.SuspendLayout();
            groupShift.SuspendLayout();
            groupScale.SuspendLayout();
            SuspendLayout();
            // 
            // graphicPanel
            // 
            graphicPanel.Location = new Point(348, 12);
            graphicPanel.Name = "graphicPanel";
            graphicPanel.Size = new Size(1232, 545);
            graphicPanel.TabIndex = 0;
            // 
            // groupBuild
            // 
            groupBuild.Controls.Add(buttonDraw);
            groupBuild.Controls.Add(comboFigures);
            groupBuild.Location = new Point(12, 103);
            groupBuild.Name = "groupBuild";
            groupBuild.Size = new Size(143, 88);
            groupBuild.TabIndex = 0;
            groupBuild.TabStop = false;
            groupBuild.Text = "Объекты";
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(6, 51);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(121, 23);
            buttonDraw.TabIndex = 0;
            buttonDraw.Text = "Нарисовать";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // comboFigures
            // 
            comboFigures.FormattingEnabled = true;
            comboFigures.Location = new Point(6, 22);
            comboFigures.Name = "comboFigures";
            comboFigures.Size = new Size(121, 23);
            comboFigures.TabIndex = 0;
            // 
            // groupProjection
            // 
            groupProjection.Controls.Add(radioPerspectiveIsometric);
            groupProjection.Controls.Add(radioPerspectiveCentral);
            groupProjection.Location = new Point(12, 12);
            groupProjection.Name = "groupProjection";
            groupProjection.Size = new Size(143, 87);
            groupProjection.TabIndex = 1;
            groupProjection.TabStop = false;
            groupProjection.Text = "Проекция";
            // 
            // radioPerspectiveIsometric
            // 
            radioPerspectiveIsometric.AutoSize = true;
            radioPerspectiveIsometric.Location = new Point(6, 47);
            radioPerspectiveIsometric.Name = "radioPerspectiveIsometric";
            radioPerspectiveIsometric.Size = new Size(117, 19);
            radioPerspectiveIsometric.TabIndex = 1;
            radioPerspectiveIsometric.TabStop = true;
            radioPerspectiveIsometric.Text = "Изометрическая";
            radioPerspectiveIsometric.UseVisualStyleBackColor = true;
            // 
            // radioPerspectiveCentral
            // 
            radioPerspectiveCentral.AutoSize = true;
            radioPerspectiveCentral.Location = new Point(6, 22);
            radioPerspectiveCentral.Name = "radioPerspectiveCentral";
            radioPerspectiveCentral.Size = new Size(97, 19);
            radioPerspectiveCentral.TabIndex = 1;
            radioPerspectiveCentral.TabStop = true;
            radioPerspectiveCentral.Text = "Центральная";
            radioPerspectiveCentral.UseVisualStyleBackColor = true;
            radioPerspectiveCentral.CheckedChanged += radioPerspectiveCentral_CheckedChanged;
            // 
            // groupRotate
            // 
            groupRotate.Controls.Add(buttonRotateAxes);
            groupRotate.Controls.Add(inputAngle);
            groupRotate.Controls.Add(label1);
            groupRotate.Controls.Add(comboAxes);
            groupRotate.Location = new Point(12, 197);
            groupRotate.Name = "groupRotate";
            groupRotate.Size = new Size(330, 100);
            groupRotate.TabIndex = 2;
            groupRotate.TabStop = false;
            groupRotate.Text = "Поворот";
            // 
            // buttonRotateAxes
            // 
            buttonRotateAxes.Location = new Point(143, 18);
            buttonRotateAxes.Name = "buttonRotateAxes";
            buttonRotateAxes.Size = new Size(75, 23);
            buttonRotateAxes.TabIndex = 3;
            buttonRotateAxes.Text = "Повернуть";
            buttonRotateAxes.UseVisualStyleBackColor = true;
            buttonRotateAxes.Click += buttonRotateAxes_Click;
            // 
            // inputAngle
            // 
            inputAngle.Location = new Point(75, 19);
            inputAngle.Name = "inputAngle";
            inputAngle.Size = new Size(28, 23);
            inputAngle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Поворот на";
            // 
            // comboAxes
            // 
            comboAxes.FormattingEnabled = true;
            comboAxes.Location = new Point(106, 19);
            comboAxes.Name = "comboAxes";
            comboAxes.Size = new Size(31, 23);
            comboAxes.TabIndex = 3;
            comboAxes.SelectedIndexChanged += comboAxes_SelectedIndexChanged;
            // 
            // groupShift
            // 
            groupShift.Controls.Add(buttonShiftCoords);
            groupShift.Controls.Add(label5);
            groupShift.Controls.Add(label4);
            groupShift.Controls.Add(label3);
            groupShift.Controls.Add(inputShiftZ);
            groupShift.Controls.Add(inputShiftY);
            groupShift.Controls.Add(inputShiftX);
            groupShift.Controls.Add(label2);
            groupShift.Location = new Point(12, 303);
            groupShift.Name = "groupShift";
            groupShift.Size = new Size(330, 108);
            groupShift.TabIndex = 3;
            groupShift.TabStop = false;
            groupShift.Text = "Сдвиг";
            // 
            // buttonShiftCoords
            // 
            buttonShiftCoords.Location = new Point(229, 15);
            buttonShiftCoords.Name = "buttonShiftCoords";
            buttonShiftCoords.Size = new Size(75, 23);
            buttonShiftCoords.TabIndex = 10;
            buttonShiftCoords.Text = "Сдвиг";
            buttonShiftCoords.UseVisualStyleBackColor = true;
            buttonShiftCoords.Click += buttonShiftCoords_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 19);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 9;
            label5.Text = "Z";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 19);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 8;
            label4.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 19);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 7;
            label3.Text = "X";
            // 
            // inputShiftZ
            // 
            inputShiftZ.Location = new Point(175, 16);
            inputShiftZ.Name = "inputShiftZ";
            inputShiftZ.Size = new Size(28, 23);
            inputShiftZ.TabIndex = 6;
            inputShiftZ.TextChanged += textBox3_TextChanged;
            // 
            // inputShiftY
            // 
            inputShiftY.Location = new Point(121, 16);
            inputShiftY.Name = "inputShiftY";
            inputShiftY.Size = new Size(28, 23);
            inputShiftY.TabIndex = 5;
            // 
            // inputShiftX
            // 
            inputShiftX.Location = new Point(67, 16);
            inputShiftX.Name = "inputShiftX";
            inputShiftX.Size = new Size(28, 23);
            inputShiftX.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Сдвиг на";
            // 
            // groupScale
            // 
            groupScale.Controls.Add(buttonScaleCoords);
            groupScale.Controls.Add(label6);
            groupScale.Controls.Add(label7);
            groupScale.Controls.Add(label8);
            groupScale.Controls.Add(inputScaleZ);
            groupScale.Controls.Add(inputScaleY);
            groupScale.Controls.Add(inputScaleX);
            groupScale.Controls.Add(label9);
            groupScale.Location = new Point(12, 417);
            groupScale.Name = "groupScale";
            groupScale.Size = new Size(330, 108);
            groupScale.TabIndex = 11;
            groupScale.TabStop = false;
            groupScale.Text = "Масштаб";
            // 
            // buttonScaleCoords
            // 
            buttonScaleCoords.Location = new Point(249, 15);
            buttonScaleCoords.Name = "buttonScaleCoords";
            buttonScaleCoords.Size = new Size(75, 23);
            buttonScaleCoords.TabIndex = 10;
            buttonScaleCoords.Text = "Масштаб";
            buttonScaleCoords.UseVisualStyleBackColor = true;
            buttonScaleCoords.Click += buttonScaleCoords_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 18);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 9;
            label6.Text = "Z";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 18);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 8;
            label7.Text = "Y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(121, 18);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 7;
            label8.Text = "X";
            // 
            // inputScaleZ
            // 
            inputScaleZ.Location = new Point(190, 15);
            inputScaleZ.Name = "inputScaleZ";
            inputScaleZ.Size = new Size(28, 23);
            inputScaleZ.TabIndex = 6;
            inputScaleZ.TextChanged += textBox1_TextChanged;
            // 
            // inputScaleY
            // 
            inputScaleY.Location = new Point(141, 15);
            inputScaleY.Name = "inputScaleY";
            inputScaleY.Size = new Size(28, 23);
            inputScaleY.TabIndex = 5;
            // 
            // inputScaleX
            // 
            inputScaleX.Location = new Point(87, 16);
            inputScaleX.Name = "inputScaleX";
            inputScaleX.Size = new Size(28, 23);
            inputScaleX.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 4;
            label9.Text = "Масштаб на";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1592, 687);
            Controls.Add(groupScale);
            Controls.Add(groupShift);
            Controls.Add(groupRotate);
            Controls.Add(groupProjection);
            Controls.Add(groupBuild);
            Controls.Add(graphicPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBuild.ResumeLayout(false);
            groupProjection.ResumeLayout(false);
            groupProjection.PerformLayout();
            groupRotate.ResumeLayout(false);
            groupRotate.PerformLayout();
            groupShift.ResumeLayout(false);
            groupShift.PerformLayout();
            groupScale.ResumeLayout(false);
            groupScale.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel graphicPanel;
        private GroupBox groupBuild;
        private ComboBox comboFigures;
        private Button buttonDraw;
        private GroupBox groupProjection;
        private RadioButton radioPerspectiveIsometric;
        private RadioButton radioPerspectiveCentral;
        private GroupBox groupRotate;
        private Label label1;
        private ComboBox comboAxes;
        private Button buttonRotateAxes;
        private TextBox inputAngle;
        private GroupBox groupShift;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox inputShiftZ;
        private TextBox inputShiftY;
        private TextBox inputShiftX;
        private Label label2;
        private Button buttonShiftCoords;
        private GroupBox groupScale;
        private Button buttonScaleCoords;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox inputScaleZ;
        private TextBox inputScaleY;
        private TextBox inputScaleX;
        private Label label9;
    }
}