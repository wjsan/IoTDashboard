﻿
namespace IoTDashboardControls.Components
{
    partial class WindowTheme
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextTheme = new IoTDashboardControls.Components.TextTheme(this.components);
            this.ButtonTheme = new IoTDashboardControls.Components.ButtonTheme(this.components);
            // 
            // TextTheme
            // 
            this.TextTheme.TextColor = System.Drawing.Color.Empty;
            this.TextTheme.TextFont = null;
            // 
            // ButtonTheme
            // 
            this.ButtonTheme.Color = System.Drawing.Color.Empty;
            this.ButtonTheme.ColorOnClick = System.Drawing.Color.Empty;
            this.ButtonTheme.ColorOnEnter = System.Drawing.Color.Empty;

        }

        #endregion

        public TextTheme TextTheme;
        public ButtonTheme ButtonTheme;
    }
}
