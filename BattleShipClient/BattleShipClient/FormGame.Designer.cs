﻿namespace BattleShipClient
{
    partial class FormGame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_AllyFleet = new System.Windows.Forms.DataGridView();
            this.GRB_AllyFleet = new System.Windows.Forms.GroupBox();
            this.GRB_EnemyFleet = new System.Windows.Forms.GroupBox();
            this.DGV_EnemyFleet = new System.Windows.Forms.DataGridView();
            this.PNL_InfoBar = new System.Windows.Forms.Panel();
            this.LBL_Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllyFleet)).BeginInit();
            this.GRB_AllyFleet.SuspendLayout();
            this.GRB_EnemyFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EnemyFleet)).BeginInit();
            this.PNL_InfoBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_AllyFleet
            // 
            this.DGV_AllyFleet.AllowUserToAddRows = false;
            this.DGV_AllyFleet.AllowUserToDeleteRows = false;
            this.DGV_AllyFleet.AllowUserToResizeColumns = false;
            this.DGV_AllyFleet.AllowUserToResizeRows = false;
            this.DGV_AllyFleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_AllyFleet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_AllyFleet.Location = new System.Drawing.Point(6, 19);
            this.DGV_AllyFleet.MultiSelect = false;
            this.DGV_AllyFleet.Name = "DGV_AllyFleet";
            this.DGV_AllyFleet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_AllyFleet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_AllyFleet.Size = new System.Drawing.Size(352, 322);
            this.DGV_AllyFleet.TabIndex = 0;
            this.DGV_AllyFleet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AllyFleet_CellClick);
            // 
            // GRB_AllyFleet
            // 
            this.GRB_AllyFleet.Controls.Add(this.DGV_AllyFleet);
            this.GRB_AllyFleet.Location = new System.Drawing.Point(13, 13);
            this.GRB_AllyFleet.Name = "GRB_AllyFleet";
            this.GRB_AllyFleet.Size = new System.Drawing.Size(367, 350);
            this.GRB_AllyFleet.TabIndex = 1;
            this.GRB_AllyFleet.TabStop = false;
            this.GRB_AllyFleet.Text = "Votre flotte";
            // 
            // GRB_EnemyFleet
            // 
            this.GRB_EnemyFleet.Controls.Add(this.DGV_EnemyFleet);
            this.GRB_EnemyFleet.Location = new System.Drawing.Point(386, 13);
            this.GRB_EnemyFleet.Name = "GRB_EnemyFleet";
            this.GRB_EnemyFleet.Size = new System.Drawing.Size(367, 350);
            this.GRB_EnemyFleet.TabIndex = 2;
            this.GRB_EnemyFleet.TabStop = false;
            this.GRB_EnemyFleet.Text = "Flotte ennemi";
            // 
            // DGV_EnemyFleet
            // 
            this.DGV_EnemyFleet.AllowUserToAddRows = false;
            this.DGV_EnemyFleet.AllowUserToDeleteRows = false;
            this.DGV_EnemyFleet.AllowUserToResizeColumns = false;
            this.DGV_EnemyFleet.AllowUserToResizeRows = false;
            this.DGV_EnemyFleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_EnemyFleet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_EnemyFleet.Location = new System.Drawing.Point(6, 19);
            this.DGV_EnemyFleet.MultiSelect = false;
            this.DGV_EnemyFleet.Name = "DGV_EnemyFleet";
            this.DGV_EnemyFleet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_EnemyFleet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_EnemyFleet.Size = new System.Drawing.Size(352, 322);
            this.DGV_EnemyFleet.TabIndex = 0;
            this.DGV_EnemyFleet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_EnemyFleet_CellClick);
            // 
            // PNL_InfoBar
            // 
            this.PNL_InfoBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PNL_InfoBar.Controls.Add(this.LBL_Status);
            this.PNL_InfoBar.Location = new System.Drawing.Point(13, 370);
            this.PNL_InfoBar.Name = "PNL_InfoBar";
            this.PNL_InfoBar.Size = new System.Drawing.Size(740, 47);
            this.PNL_InfoBar.TabIndex = 3;
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Status.Location = new System.Drawing.Point(3, 10);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(270, 25);
            this.LBL_Status.TabIndex = 0;
            this.LBL_Status.Text = "En attente de l\'autre joueur";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 429);
            this.Controls.Add(this.PNL_InfoBar);
            this.Controls.Add(this.GRB_EnemyFleet);
            this.Controls.Add(this.GRB_AllyFleet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGame";
            this.Text = "BattleShip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllyFleet)).EndInit();
            this.GRB_AllyFleet.ResumeLayout(false);
            this.GRB_EnemyFleet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EnemyFleet)).EndInit();
            this.PNL_InfoBar.ResumeLayout(false);
            this.PNL_InfoBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_AllyFleet;
        private System.Windows.Forms.GroupBox GRB_AllyFleet;
        private System.Windows.Forms.GroupBox GRB_EnemyFleet;
        private System.Windows.Forms.DataGridView DGV_EnemyFleet;
        private System.Windows.Forms.Panel PNL_InfoBar;
        private System.Windows.Forms.Label LBL_Status;
    }
}

