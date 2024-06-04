using System;
using System.Drawing;

namespace WindMillApp
{
    public class WindmillBladeChanger
    {
        public Image GetBladeImage(int bladeNumber)
        {
            switch (bladeNumber)
            {
                case 2:
                    return Properties.Resources.WindmillBlades2;
                case 3:
                    return Properties.Resources.WindmillBlades3;
                case 4:
                    return Properties.Resources.WindmillBlades4;
                case 5:
                    return Properties.Resources.WindmillBlades5;
                case 6:
                    return Properties.Resources.WindmillBlades6;
                default:
                    return Properties.Resources.WindmillBlades2;
            }
        }
    }
}
