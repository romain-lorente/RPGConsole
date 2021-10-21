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

        public void Attaquer(Personnage cible, int degats)
        {
            cible.SubirDegats(degats);
        }
    }
}
