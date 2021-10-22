namespace TP
{
    class Personnage
    {
        private Vie _vie = new Vie();
        private Niveau _niveau = new Niveau();

        public void SubirDegats()
        {
            _vie.SubirDegats();
        }

        public void RecevoirSoins()
        {
            _vie.RecevoirSoins();
        }

        public void Attaquer(Personnage cible)
        {
            cible.SubirDegats();
        }

        public void Soigner(Personnage cible)
        {
            cible.RecevoirSoins();
        }
    }
}
