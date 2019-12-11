using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SolarSystemApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // == Information on the Sun when tapped == //
        private void TapSun_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("The Sun",
               "Distance from Earth: 147.32 million km / 1 au" +
               "\n\nEquatorial Radius: 695,700km" +
               "\n\nEquatorial Circumference: 4.379 million km" +
               "\n\nSurface area: 6.09 × 10^12 km^2" +
               "\n\nVolume: 1.41 × 10^18 km³" +
               "\n\nMass: 1.9885 × 10^30 kg" +
               "\n\nDensity: 1.408 g/cm³",
               "Close Window");
        }

        // == Information on Mercury when tapped == //
        private void TapMercury_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Mercury",
                "Distance from Earth: 227.58 million km" +
                "\n\nDistance from the Sun: 62.398 million km" +
                "\n\nEquatorial Radius: 2,439.7 km" +
                "\n\nEquatorial Circumference: 15,329 km" +
                "\n\nSurface area: 74.8 million km²" +
                "\n\nVolume: 6.083 × 10^10 km^3" +
                "\n\nMass: 3.285 × 10^23 kg" +
                "\n\nDensity: 5.43 g/cm³",
                "Close Window");
        }

        // == Information on Venus when tapped == //
        private void TapVenus_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Venus",
                "Distance from Earth: 327.03 million km" +
                "\n\nDistance from the Sun: 108.9 million km" +
                "\n\nEquatorial Radius: 6,051.8 km" +
                "\n\nEquatorial Circumference: 38,025 km" +
                "\n\nSurface area: 460.2 million km²" +
                "\n\nVolume: 9.38 x 10^11 km^3" +
                "\n\nMass: 4.867 × 10^24 kg" +
                "\n\nDensity: 5.24 g/cm³",
                "Close Window");
        }

        // == Information on Earth when tapped == //
        private void TapEarth_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Earth",
                "Distance from the Sun: 147.32 million km" +
                "\n\nEquatorial Radius: 6,371 km" +
                "\n\nEquatorial Circumference: " +
                "\n\nSurface area: 40,075 km" +
                "\n\nVolume: 1.08321 × 10^12 km^3" +
                "\n\nMass: 5.972 × 10^24 kg" +
                "\n\nDensity: 5.51 g/cm³",
                "Close Window");
        }

        // == Information on Mars when tapped == //
        private void TapMars_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Mars",
                "Distance from Earth: 262.51 million km" +
                "\n\nDistance from the Sun: 242.51 million km" +
                "\n\nEquatorial Radius: 3,389.5 km" +
                "\n\nEquatorial Circumference: 21,344 km" +
                "\n\nSurface area: 144.8 million km²" +
                "\n\nVolume: 1.6318 x 10¹¹ km³" +
                "\n\nMass: 6.39 × 10^23 kg" +
                "\n\nDensity: 3.93 g/cm³",
                "Close Window");
        }

        // == Information on Jupiter when tapped == //
        private void TapJupiter_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Jupiter",
               "Distance from Earth: 340.93 million km" +
               "\n\nDistance from the Sun: 783.55 million km" +
               "\n\nEquatorial Radius: 69,911 km" +
               "\n\nEquatorial Circumference: 439,264 km" +
               "\n\nSurface area: 61.42 billion km²" +
               "\n\nVolume: 1.43 x 10^15 km³" +
               "\n\nMass: 1.898 × 10^27 kg" +
               "\n\nDensity: 1.33 g/cm³",
               "Close Window");
        }

        // == Information on Saturn when tapped == //
        private void TapSaturn_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Saturn",
               "Distance from Earth: 1.3836 billion km" +
               "\n\nDistance from the Sun: 1.4986 billion km" +
               "\n\nEquatorial Radius: 58,232 km" +
               "\n\nEquatorial Circumference: 378,675 km" +
               "\n\nSurface area: 42.7 billion km²" +
               "\n\nVolume: 8.27 x 10^14 km³" +
               "\n\nMass: 5.683 × 10^26 kg" +
               "\n\nDensity: 687 kg/m³",
               "Close Window");
        }

        // == Information on Uranus when tapped == //
        private void TapUranus_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Uranus",
               "Distance from Earth: 2.4988 billion km" +
               "\n\nDistance from the Sun: 2.9653 billion km" +
               "\n\nEquatorial Radius: 25,559 km" +
               "\n\nEquatorial Circumference: 160,590 km" +
               "\n\nSurface area: 8.083 billion km²" +
               "\n\nVolume: 6.833 x 10^13 km³" +
               "\n\nMass: 8.681 × 10^25 kg" +
               "\n\nDensity: 1.27 g/cm³",
               "Close Window");
        }

        // == Information on Neptune when tapped == //
        private void TapNeptune_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Neptune",
               "Distance from Earth: 4.6307 billion km" +
               "\n\nDistance from the Sun: 4.4773 billion km" +
               "\n\nEquatorial Radius: 24,622 km" +
               "\n\nEquatorial Circumference: 155,600 km" +
               "\n\nSurface area: 7.618 billion km²" +
               "\n\nVolume: 6.3 x 10^13 km³" +
               "\n\nMass: 1.024 × 10^26 kg" +
               "\n\nDensity: 1.64 g/cm³",
               "Close Window");
        }

        // All information regarding the planets was taken from Wikipedia
    }
}
