namespace TP
{
    class Vie
    {
        private PointsDeVie _pointsDeVie = new PointsDeVie();
        private Vivant _vivant = new Vivant();

        public void SubirDegats(int degats)
        {
            bool estEnVie = _pointsDeVie.Retirer(degats);

            _vivant.DefinirStatutEnVie(estEnVie);
        }
    }
}
