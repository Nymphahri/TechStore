using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel; // Requerido para DesignerSerializationVisibility

namespace TechStore // Agregado para solucionar la advertencia CA1050
{
    public class PanelDegradado : Panel
    {
        // El atributo Visible le dice al diseñador de Visual Studio que guarde los cambios
        // que hagas desde la ventana de Propiedades. Si no quieres que se vean en el
        // diseñador, cambia "Visible" por "Hidden".

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorSuperior { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorInferior { get; set; }

        public PanelDegradado()
        {
            this.Resize += ManejarCambioDeTamano;
        }

        private void ManejarCambioDeTamano(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush pincelDegradado = new LinearGradientBrush(
                this.ClientRectangle,
                this.ColorSuperior,
                this.ColorInferior,
                90F))
            {
                e.Graphics.FillRectangle(pincelDegradado, this.ClientRectangle);
            }

            base.OnPaint(e);
        }
    }
}