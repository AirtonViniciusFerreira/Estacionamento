using Estacionamento.Geral.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Geral.Controles
{
    public partial class MenuControle : UserControl
    {
        public MenuControle()
        {
            InitializeComponent();
        }

        private void MenuControle_Load(object sender, EventArgs e)
        {
            var menus = CreateMenus();
            tlpMenusBotoes
                .RowCount += menus.Count;
            menus
                .ForEach(menu =>
                {
                    tlpMenusBotoes
                        .RowStyles
                        .Add(new RowStyle(SizeType.AutoSize));
                    var btnMenu = new Button
                    {
                        Name = menu.Nome,
                        Text = menu.Nome,
                        Dock = DockStyle.Fill
                    };
                    tlpMenusBotoes
                        .Controls
                        .Add(btnMenu, 0, menus.IndexOf(menu) + 1);
                });
        }


        private List<MenuDto> CreateMenus()
        {
            return new List<MenuDto>
            {
                new MenuDto
                {
                    Id = 1,
                    Nome = "Inicio",
                    ResourceNome = "MenuInicio"
                },
                new MenuDto
                {
                    Id = 2,
                    Nome = "Usuarios",
                    ResourceNome = "MenuUsuarios"
                },
                new MenuDto
                {
                    Id = 1,
                    Nome = "Estacionamentos",
                    ResourceNome = "MenuEstacionamentoss"
                },
                new MenuDto
                {
                    Id = 1,
                    Nome = "Veiculos",
                    ResourceNome = "MenuVeiculos"
                },
            };
        }
    }
}
