
namespace WebBrowserDemo
{
    partial class WebBrowser
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Tab = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingsButton = new FontAwesome.Sharp.IconButton();
            this.SearchBar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            this.FwdButton = new FontAwesome.Sharp.IconButton();
            this.BackButton = new FontAwesome.Sharp.IconButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.Tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.BackColor = System.Drawing.SystemColors.Desktop;
            this.Tab.Controls.Add(this.iconButton7);
            this.Tab.Controls.Add(this.MinimizeButton);
            this.Tab.Controls.Add(this.MaximizeButton);
            this.Tab.Controls.Add(this.CloseButton);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(800, 26);
            this.Tab.TabIndex = 0;
            this.Tab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab_MouseDown);
            this.Tab.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tab_MouseMove);
            this.Tab.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tab_MouseUp);
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.iconButton7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Chrome;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 20;
            this.iconButton7.Location = new System.Drawing.Point(0, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(93, 26);
            this.iconButton7.TabIndex = 3;
            this.iconButton7.Text = "Browser";
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 20;
            this.MinimizeButton.Location = new System.Drawing.Point(707, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(31, 26);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.MaximizeButton.IconColor = System.Drawing.Color.White;
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 20;
            this.MaximizeButton.Location = new System.Drawing.Point(738, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(31, 26);
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 20;
            this.CloseButton.Location = new System.Drawing.Point(769, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 26);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.SettingsButton);
            this.panel2.Controls.Add(this.SearchBar);
            this.panel2.Controls.Add(this.RefreshButton);
            this.panel2.Controls.Add(this.FwdButton);
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 31);
            this.panel2.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SettingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SettingsButton.IconColor = System.Drawing.Color.White;
            this.SettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsButton.IconSize = 20;
            this.SettingsButton.Location = new System.Drawing.Point(769, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(31, 31);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            this.SearchBar.AcceptsReturn = false;
            this.SearchBar.AcceptsTab = false;
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.AnimationSpeed = 200;
            this.SearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchBar.AutoSizeHeight = true;
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBar.BackgroundImage")));
            this.SearchBar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SearchBar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchBar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SearchBar.BorderColorIdle = System.Drawing.Color.Silver;
            this.SearchBar.BorderRadius = 20;
            this.SearchBar.BorderThickness = 1;
            this.SearchBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SearchBar.DefaultText = "";
            this.SearchBar.FillColor = System.Drawing.Color.White;
            this.SearchBar.HideSelection = true;
            this.SearchBar.IconLeft = null;
            this.SearchBar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.IconPadding = 10;
            this.SearchBar.IconRight = null;
            this.SearchBar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.Lines = new string[0];
            this.SearchBar.Location = new System.Drawing.Point(99, 5);
            this.SearchBar.MaxLength = 32767;
            this.SearchBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchBar.Modified = false;
            this.SearchBar.Multiline = false;
            this.SearchBar.Name = "SearchBar";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchBar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBar.OnIdleState = stateProperties4;
            this.SearchBar.Padding = new System.Windows.Forms.Padding(3);
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SearchBar.PlaceholderText = "Enter text";
            this.SearchBar.ReadOnly = false;
            this.SearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchBar.SelectedText = "";
            this.SearchBar.SelectionLength = 0;
            this.SearchBar.SelectionStart = 0;
            this.SearchBar.ShortcutsEnabled = true;
            this.SearchBar.Size = new System.Drawing.Size(670, 22);
            this.SearchBar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SearchBar.TabIndex = 6;
            this.SearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBar.TextMarginBottom = 0;
            this.SearchBar.TextMarginLeft = 3;
            this.SearchBar.TextMarginTop = 1;
            this.SearchBar.TextPlaceholder = "Enter text";
            this.SearchBar.UseSystemPasswordChar = false;
            this.SearchBar.WordWrap = true;
            this.SearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBar_KeyPress);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RefreshButton.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.RefreshButton.IconColor = System.Drawing.Color.White;
            this.RefreshButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshButton.IconSize = 20;
            this.RefreshButton.Location = new System.Drawing.Point(62, 0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(31, 31);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // FwdButton
            // 
            this.FwdButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FwdButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.FwdButton.FlatAppearance.BorderSize = 0;
            this.FwdButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.FwdButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.FwdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FwdButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FwdButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FwdButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.FwdButton.IconColor = System.Drawing.Color.White;
            this.FwdButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FwdButton.IconSize = 20;
            this.FwdButton.Location = new System.Drawing.Point(31, 0);
            this.FwdButton.Name = "FwdButton";
            this.FwdButton.Size = new System.Drawing.Size(31, 31);
            this.FwdButton.TabIndex = 4;
            this.FwdButton.UseVisualStyleBackColor = true;
            this.FwdButton.Click += new System.EventHandler(this.FwdButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BackButton.IconColor = System.Drawing.Color.White;
            this.BackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackButton.IconSize = 20;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(31, 31);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 57);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 393);
            this.webBrowser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Tab;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton SettingsButton;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBar;
        private FontAwesome.Sharp.IconButton RefreshButton;
        private FontAwesome.Sharp.IconButton FwdButton;
        private FontAwesome.Sharp.IconButton BackButton;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

