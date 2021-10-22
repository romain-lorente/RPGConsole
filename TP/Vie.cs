namespace TP
{
    class Vie
    {
        private PointsDeVie _pointsDeVie = new PointsDeVie();
        private Vivant _vivant = new Vivant();

        public void SubirDegats()
        {
            bool estEnVie = _pointsDeVie.Retirer();

            _vivant.DefinirStatutEnVie(estEnVie);
        }

        public void RecevoirSoins()
        {
            _pointsDeVie.Ajouter();
        }
    }
}
