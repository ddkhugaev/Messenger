
namespace Messenger
{
    partial class FormMessenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewChatList = new System.Windows.Forms.DataGridView();
            this.ColumnChats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.ColumnMyMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOtherMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChatList
            // 
            this.dataGridViewChatList.AllowUserToAddRows = false;
            this.dataGridViewChatList.AllowUserToDeleteRows = false;
            this.dataGridViewChatList.AllowUserToResizeColumns = false;
            this.dataGridViewChatList.AllowUserToResizeRows = false;
            this.dataGridViewChatList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatList.ColumnHeadersVisible = false;
            this.dataGridViewChatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnChats});
            this.dataGridViewChatList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewChatList.MultiSelect = false;
            this.dataGridViewChatList.Name = "dataGridViewChatList";
            this.dataGridViewChatList.ReadOnly = true;
            this.dataGridViewChatList.RowHeadersVisible = false;
            this.dataGridViewChatList.RowHeadersWidth = 51;
            this.dataGridViewChatList.RowTemplate.Height = 50;
            this.dataGridViewChatList.Size = new System.Drawing.Size(400, 672);
            this.dataGridViewChatList.TabIndex = 0;
            // 
            // ColumnChats
            // 
            this.ColumnChats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnChats.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnChats.HeaderText = "Column";
            this.ColumnChats.MinimumWidth = 6;
            this.ColumnChats.Name = "ColumnChats";
            this.ColumnChats.ReadOnly = true;
            this.ColumnChats.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.AllowUserToAddRows = false;
            this.dataGridViewChat.AllowUserToDeleteRows = false;
            this.dataGridViewChat.AllowUserToResizeColumns = false;
            this.dataGridViewChat.AllowUserToResizeRows = false;
            this.dataGridViewChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewChat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.ColumnHeadersVisible = false;
            this.dataGridViewChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMyMessages,
            this.ColumnOtherMessages});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewChat.Location = new System.Drawing.Point(424, 0);
            this.dataGridViewChat.MultiSelect = false;
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.ReadOnly = true;
            this.dataGridViewChat.RowHeadersVisible = false;
            this.dataGridViewChat.RowHeadersWidth = 51;
            this.dataGridViewChat.RowTemplate.Height = 150;
            this.dataGridViewChat.Size = new System.Drawing.Size(832, 672);
            this.dataGridViewChat.TabIndex = 1;
            // 
            // ColumnMyMessages
            // 
            this.ColumnMyMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnMyMessages.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnMyMessages.HeaderText = "ColumnMyMessages";
            this.ColumnMyMessages.MinimumWidth = 6;
            this.ColumnMyMessages.Name = "ColumnMyMessages";
            this.ColumnMyMessages.ReadOnly = true;
            this.ColumnMyMessages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnOtherMessages
            // 
            this.ColumnOtherMessages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnOtherMessages.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnOtherMessages.HeaderText = "ColumnOtherMessages";
            this.ColumnOtherMessages.MinimumWidth = 6;
            this.ColumnOtherMessages.Name = "ColumnOtherMessages";
            this.ColumnOtherMessages.ReadOnly = true;
            this.ColumnOtherMessages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 673);
            this.Controls.Add(this.dataGridViewChat);
            this.Controls.Add(this.dataGridViewChatList);
            this.Name = "FormMessenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мессенджер";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChatList;
        private System.Windows.Forms.DataGridView dataGridViewChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMyMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOtherMessages;
    }
}