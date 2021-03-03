﻿
namespace IoTDashboard.Components
{
    partial class Theme
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
            this.ScreenTheme = new IoTDashboard.Components.ScreenTheme(this.components);
            this.TextTheme = new IoTDashboard.Components.TextTheme(this.components);
            this.WindowTheme = new IoTDashboard.Components.WindowTheme(this.components);
            this.MenuTheme = new IotDashboardControls.Themes.MenuTheme(this.components);
            this.ButtonTheme = new IotDashboardControls.Themes.ButtonTheme(this.components);
            // 
            // ScreenTheme
            // 
            this.ScreenTheme.BackgroundColor = System.Drawing.Color.Empty;
            // 
            // TextTheme
            // 
            this.TextTheme.TextColor = System.Drawing.Color.Empty;
            this.TextTheme.TextFont = null;
            // 
            // WindowTheme
            // 
            this.WindowTheme.BackgroudColor = System.Drawing.Color.Empty;
            // 
            // MenuTheme
            // 
            this.MenuTheme.HeaderColor = System.Drawing.Color.Empty;
            this.MenuTheme.MenuColor = System.Drawing.Color.Empty;
            // 
            // ButtonTheme
            // 
            this.ButtonTheme.Color = System.Drawing.Color.Empty;
            this.ButtonTheme.ColorOnClick = System.Drawing.Color.Empty;
            this.ButtonTheme.ColorOnEnter = System.Drawing.Color.Empty;

        }

        #endregion

        public ScreenTheme ScreenTheme;
        public TextTheme TextTheme;
        public WindowTheme WindowTheme;
        public IotDashboardControls.Themes.MenuTheme MenuTheme;
        public IotDashboardControls.Themes.ButtonTheme ButtonTheme;
    }
}
