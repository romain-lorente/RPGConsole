namespace TP
{
    class PointsDeVie
    {
        private int _pointsDeVie;

        public PointsDeVie()
        {
            _pointsDeVie = 1000;
        }

        public bool Retirer(int degats)
        {
            _pointsDeVie -= degats;

            if (_pointsDeVie < 0)
                _pointsDeVie = 0;

            return _pointsDeVie > 0;
        }
    }
}
