
namespace BloodBank
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnExit = new XanderUI.XUIButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateDonarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.allDonarDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBloodDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ButtonImage")));
            this.btnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.btnExit.ButtonText = "X";
            this.btnExit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.ClickTextColor = System.Drawing.Color.Red;
            this.btnExit.CornerRadius = 5;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnExit.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExit.Location = new System.Drawing.Point(892, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 27);
            this.btnExit.TabIndex = 13;
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donarToolStripMenuItem,
            this.searchBloodDonarToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.deleteDonarToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 68);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donarToolStripMenuItem
            // 
            this.donarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonarToolStripMenuItem,
            this.UpdateDonarDetails,
            this.allDonarDetailsToolStripMenuItem});
            this.donarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donarToolStripMenuItem.Image")));
            this.donarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donarToolStripMenuItem.Name = "donarToolStripMenuItem";
            this.donarToolStripMenuItem.Size = new System.Drawing.Size(101, 64);
            this.donarToolStripMenuItem.Text = "Donar";
            // 
            // addNewDonarToolStripMenuItem
            // 
            this.addNewDonarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDonarToolStripMenuItem.Image")));
            this.addNewDonarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDonarToolStripMenuItem.Name = "addNewDonarToolStripMenuItem";
            this.addNewDonarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.addNewDonarToolStripMenuItem.Text = "Add New Donar";
            this.addNewDonarToolStripMenuItem.Click += new System.EventHandler(this.addNewDonarToolStripMenuItem_Click);
            // 
            // UpdateDonarDetails
            // 
            this.UpdateDonarDetails.Image = ((System.Drawing.Image)(resources.GetObject("UpdateDonarDetails.Image")));
            this.UpdateDonarDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateDonarDetails.Name = "UpdateDonarDetails";
            this.UpdateDonarDetails.Size = new System.Drawing.Size(184, 26);
            this.UpdateDonarDetails.Text = "Update Details";
            this.UpdateDonarDetails.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // allDonarDetailsToolStripMenuItem
            // 
            this.allDonarDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDonarDetailsToolStripMenuItem.Image")));
            this.allDonarDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allDonarDetailsToolStripMenuItem.Name = "allDonarDetailsToolStripMenuItem";
            this.allDonarDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.allDonarDetailsToolStripMenuItem.Text = "All Donar Details";
            this.allDonarDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDonarDetailsToolStripMenuItem_Click);
            // 
            // searchBloodDonarToolStripMenuItem
            // 
            this.searchBloodDonarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.bloodGroupToolStripMenuItem});
            this.searchBloodDonarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchBloodDonarToolStripMenuItem.Image")));
            this.searchBloodDonarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchBloodDonarToolStripMenuItem.Name = "searchBloodDonarToolStripMenuItem";
            this.searchBloodDonarToolStripMenuItem.Size = new System.Drawing.Size(173, 64);
            this.searchBloodDonarToolStripMenuItem.Text = "Search Blood Donar";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locationToolStripMenuItem.Image")));
            this.locationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.locationToolStripMenuItem.Text = "Location";
            // 
            // bloodGroupToolStripMenuItem
            // 
            this.bloodGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bloodGroupToolStripMenuItem.Image")));
            this.bloodGroupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bloodGroupToolStripMenuItem.Text = "Blood Group";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(98, 64);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increaseToolStripMenuItem.Image")));
            this.increaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.increaseToolStripMenuItem.Text = "Increase";
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decreaseToolStripMenuItem.Image")));
            this.decreaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // deleteDonarToolStripMenuItem
            // 
            this.deleteDonarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDonorToolStripMenuItem});
            this.deleteDonarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonarToolStripMenuItem.Image")));
            this.deleteDonarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonarToolStripMenuItem.Name = "deleteDonarToolStripMenuItem";
            this.deleteDonarToolStripMenuItem.Size = new System.Drawing.Size(137, 64);
            this.deleteDonarToolStripMenuItem.Text = "Delete Donar";
            // 
            // deleteDonorToolStripMenuItem
            // 
            this.deleteDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonorToolStripMenuItem.Image")));
            this.deleteDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            this.deleteDonorToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deleteDonorToolStripMenuItem.Text = "DeleteDonor";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(122, 64);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 531);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private XanderUI.XUIButton btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBloodDonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateDonarDetails;
        private System.Windows.Forms.ToolStripMenuItem allDonarDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem;
    }
}