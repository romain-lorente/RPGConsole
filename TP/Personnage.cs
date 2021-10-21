namespace TP
{
    class Personnage
    {
        private Vie _vie = new Vie();
        private Niveau _niveau = new Niveau();

        public void SubirDegats(int degats)
        {
            _vie.SubirDegats(degats);
        }

        public void RecevoirSoins(int soins)
        {
            _vie.RecevoirSoins(soins);
        }

        public void Attaquer(Personnage cible, int degats)
        {
            cible.SubirDegats(degats);
        }

        public void Soigner(Personnage cible, int soins)
        {
            cible.RecevoirSoins(soins);
        }
    }
}
