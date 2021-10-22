namespace TP
{
    class PointsDeVie
    {
        private int _pointsDeVie;

        public PointsDeVie()
        {
            _pointsDeVie = 1000;
        }

        public bool VieSuperieureAZero()
        {
            return _pointsDeVie > 0;
        }

        public void Ajouter()
        {
            if(VieSuperieureAZero())
                _pointsDeVie += 250;

            RemettreVieAuMaximum();
        }

        public bool Retirer()
        {
            _pointsDeVie -= 500;

            RemettreVieAZero();

            return VieSuperieureAZero();
        }

        private void RemettreVieAZero()
        {
            if (_pointsDeVie < 0)
                _pointsDeVie = 0;
        }

        private void RemettreVieAuMaximum()
        {
            if (_pointsDeVie > 1000)
                _pointsDeVie = 1000;
        }
    }
}
