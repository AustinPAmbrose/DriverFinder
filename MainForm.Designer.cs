namespace DriverFinder
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            filtersBox = new GroupBox();
            voltageMinLabel = new Label();
            voltageMinTextBox = new TextBox();
            resetButton = new Button();
            powerLabel = new Label();
            powerTextBox = new TextBox();
            voltageLabel = new Label();
            voltageMaxTextBox = new TextBox();
            currentLabel = new Label();
            currentText = new TextBox();
            driverData = new DBDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            mountingColumn = new DataGridViewTextBoxColumn();
            feedColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            driverBindingSource = new BindingSource(components);
            filtersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)driverData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            SuspendLayout();
            // 
            // filtersBox
            // 
            filtersBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filtersBox.Controls.Add(voltageMinLabel);
            filtersBox.Controls.Add(voltageMinTextBox);
            filtersBox.Controls.Add(resetButton);
            filtersBox.Controls.Add(powerLabel);
            filtersBox.Controls.Add(powerTextBox);
            filtersBox.Controls.Add(voltageLabel);
            filtersBox.Controls.Add(voltageMaxTextBox);
            filtersBox.Controls.Add(currentLabel);
            filtersBox.Controls.Add(currentText);
            filtersBox.Location = new Point(12, 12);
            filtersBox.Name = "filtersBox";
            filtersBox.Size = new Size(789, 70);
            filtersBox.TabIndex = 1;
            filtersBox.TabStop = false;
            filtersBox.Text = "Filters";
            // 
            // voltageMinLabel
            // 
            voltageMinLabel.AutoSize = true;
            voltageMinLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            voltageMinLabel.Location = new Point(348, 35);
            voltageMinLabel.Name = "voltageMinLabel";
            voltageMinLabel.Size = new Size(95, 15);
            voltageMinLabel.TabIndex = 8;
            voltageMinLabel.Text = "Voltage Min (V):";
            // 
            // voltageMinTextBox
            // 
            voltageMinTextBox.Location = new Point(445, 31);
            voltageMinTextBox.Name = "voltageMinTextBox";
            voltageMinTextBox.Size = new Size(60, 23);
            voltageMinTextBox.TabIndex = 2;
            voltageMinTextBox.TextAlign = HorizontalAlignment.Center;
            voltageMinTextBox.TextChanged += filtersChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(698, 31);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 4;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            powerLabel.Location = new Point(519, 35);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new Size(96, 15);
            powerLabel.TabIndex = 5;
            powerLabel.Text = "Power Max (W):";
            // 
            // powerTextBox
            // 
            powerTextBox.Location = new Point(618, 31);
            powerTextBox.Name = "powerTextBox";
            powerTextBox.Size = new Size(60, 23);
            powerTextBox.TabIndex = 3;
            powerTextBox.TextAlign = HorizontalAlignment.Center;
            powerTextBox.TextChanged += filtersChanged;
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            voltageLabel.Location = new Point(171, 35);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(98, 15);
            voltageLabel.TabIndex = 3;
            voltageLabel.Text = "Voltage Max (V):";
            // 
            // voltageMaxTextBox
            // 
            voltageMaxTextBox.Location = new Point(272, 31);
            voltageMaxTextBox.Name = "voltageMaxTextBox";
            voltageMaxTextBox.Size = new Size(60, 23);
            voltageMaxTextBox.TabIndex = 1;
            voltageMaxTextBox.TextAlign = HorizontalAlignment.Center;
            voltageMaxTextBox.TextChanged += filtersChanged;
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            currentLabel.Location = new Point(13, 35);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(83, 15);
            currentLabel.TabIndex = 1;
            currentLabel.Text = "Current (mA):";
            // 
            // currentText
            // 
            currentText.Location = new Point(98, 31);
            currentText.Name = "currentText";
            currentText.Size = new Size(60, 23);
            currentText.TabIndex = 0;
            currentText.TextAlign = HorizontalAlignment.Center;
            currentText.TextChanged += filtersChanged;
            // 
            // driverData
            // 
            driverData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            driverData.AutoGenerateColumns = false;
            driverData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            driverData.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, mountingColumn, feedColumn, dataGridViewTextBoxColumn9 });
            driverData.DataSource = driverBindingSource;
            driverData.DoubleBuffered = true;
            driverData.Location = new Point(12, 88);
            driverData.Name = "driverData";
            driverData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            driverData.Size = new Size(789, 350);
            driverData.TabIndex = 2;
            driverData.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Distributor";
            dataGridViewTextBoxColumn1.HeaderText = "Distributor";
            dataGridViewTextBoxColumn1.MinimumWidth = 100;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn2.DataPropertyName = "PartNumber";
            dataGridViewTextBoxColumn2.HeaderText = "PartNumber";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 97;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "Current";
            dataGridViewTextBoxColumn3.HeaderText = "Current (mA)";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 102;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.DataPropertyName = "Voltage";
            dataGridViewTextBoxColumn4.HeaderText = "Voltage (V)";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 89;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn5.DataPropertyName = "Power";
            dataGridViewTextBoxColumn5.HeaderText = "Power (W)";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 87;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "Size";
            dataGridViewTextBoxColumn6.HeaderText = "Size (Inches)";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 97;
            // 
            // mountingColumn
            // 
            mountingColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            mountingColumn.DataPropertyName = "Mounting";
            mountingColumn.HeaderText = "Mounting";
            mountingColumn.Name = "mountingColumn";
            mountingColumn.Resizable = DataGridViewTriState.True;
            mountingColumn.Width = 85;
            // 
            // feedColumn
            // 
            feedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            feedColumn.DataPropertyName = "Feed";
            feedColumn.HeaderText = "Feed";
            feedColumn.Name = "feedColumn";
            feedColumn.Width = 57;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn9.DataPropertyName = "Dimming";
            dataGridViewTextBoxColumn9.HeaderText = "Dimming";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Driver);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 450);
            Controls.Add(driverData);
            Controls.Add(filtersBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Driver Finder";
            FormClosing += MainForm_FormClosing;
            filtersBox.ResumeLayout(false);
            filtersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)driverData).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox filtersBox;
        private TextBox currentText;
        private Label currentLabel;
        private Label voltageLabel;
        private TextBox voltageMaxTextBox;
        private DataGridView dataGridView1;
        private Label powerLabel;
        private TextBox powerTextBox;
        private Button resetButton;
        private DataGridViewTextBoxColumn distributorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mountingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dimmingDataGridViewTextBoxColumn;
        private DBDataGridView driverData;
        private Label voltageMinLabel;
        private TextBox voltageMinTextBox;
        private BindingSource driverBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn mountingColumn;
        private DataGridViewTextBoxColumn feedColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
