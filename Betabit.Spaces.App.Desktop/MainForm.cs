using Betabit.Spaces.App.Clients;
using Betabit.Spaces.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betabit.Spaces.App
{
    public partial class MainForm : Form
    {
        private ISpacesClient spacesClient;
        private readonly IReservationsClient reservationsClient;

        public MainForm(ISpacesClient spacesClient, IReservationsClient reservationsClient)
        {
            this.spacesClient = spacesClient;
            this.reservationsClient = reservationsClient;
            InitializeComponent();
            Init();
        }

        private async void  Init()
        {
            var spaces = await spacesClient.GetSpaces();
            SpacesListBox.Items.Clear();
            foreach(var space in spaces)
            {
                SpacesListBox.Items.Add(space);
            }
        }

        private async void OnSpaceSelected(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            var space = (Space)listBox.SelectedItem;
            ReservationsGridView.Rows.Clear();
            var reservations = await spacesClient.GetSpaceReservations(space.Code);
            foreach (var reservation in reservations)
            {
                ReservationsGridView.Rows.Add(reservation.SpaceCode, reservation.Reserver, reservation.Start, reservation.End);
            }
        }
    }
}
