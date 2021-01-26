using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox___Zoeken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] pkmn = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran", "Nidorina", "Nidoqueen", "Nidoran", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
            

            foreach(string s in pkmn)
            {
                ListBoxItem element = new ListBoxItem();
                element.Content = s;
                LstPkmn.Items.Add(element);
            }
        }

        private void BtnZoekOpNaam_Click(object sender, RoutedEventArgs e)
        {
            string pkmnNaam = TxtPkmnZoek.Text;
            int pkmnNummer = PkmnZoekenOpNaam(LstPkmn, pkmnNaam);
            LblResultaat.Content = "";
            LblResultaat.Content = $"{pkmnNaam} heeft DexNummer {pkmnNummer + 1:X3}";
        }

        private int PkmnZoekenOpNaam(ListBox lijst, string teZoeken)
        {
            int returnWaarde = -1;
            int counter = 0;
            ListBoxItem element;
            while(returnWaarde == -1 && counter < lijst.Items.Count)
            {
                element = (ListBoxItem)lijst.Items[counter];
                if(element.Content.ToString() == teZoeken)
                {
                    returnWaarde = counter;
                }
                else
                {
                    counter++;
                }
            }
            return returnWaarde;
        }

        private void BtnZoekOpNummer_Click(object sender, RoutedEventArgs e)
        {
            int pkmnNummer = Convert.ToInt32(TxtPkmnZoek.Text);
            string pkmnNaam = PkmnZoekenOpNummer(LstPkmn, pkmnNummer);
            LblResultaat.Content = "";
            LblResultaat.Content = $"Dex nummer {pkmnNummer:X3}: {pkmnNaam}";
        }

        private string PkmnZoekenOpNummer(ListBox lijst, int teZoeken)
        {
            string returnWaarde = "";
            int teZoekenNummer = teZoeken - 1;

            if (teZoekenNummer > lijst.Items.Count)
            {
                MessageBox.Show("Er zijn slechts 151 Pokémon", "Getal te groot", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ListBoxItem element = (ListBoxItem)lijst.Items[teZoekenNummer];
                returnWaarde = element.Content.ToString();
            }

            return returnWaarde;
        }

        private void BtnSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            int dexnummer = LstPkmn.SelectedIndex + 1;
            string pkmnNaam = PkmnSelectie(LstPkmn);
            LblResultaat.Content = "";
            LblResultaat.Content = $"{dexnummer:X3}: {pkmnNaam}";
        }

        private string PkmnSelectie(ListBox lijst)
        {
            string returnWaarde;

            ListBoxItem element = (ListBoxItem)lijst.SelectedItem;
            returnWaarde = element.Content.ToString();

            return returnWaarde;
        }

        private void BtnVervangSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            VervangSelectedItem(LstPkmn, TxtPkmnZoek.Text);
        }

        private void VervangSelectedItem(ListBox lijst, string nieuwePkmn)
        {
            int selectie = lijst.SelectedIndex;
            ListBoxItem element;

            if(selectie == -1)
            {
                MessageBox.Show("Geen Pokémon geselecteerd", "Geen selectie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                element = (ListBoxItem)lijst.SelectedItem;
                element.Content = nieuwePkmn;
            }

        }

        private void BtnAlfabetisch_Click(object sender, RoutedEventArgs e)
        {
            LstPkmn.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void BtnLeegmaken_Click(object sender, RoutedEventArgs e)
        {
            LstPkmn.Items.Clear();
        }
    }
}
