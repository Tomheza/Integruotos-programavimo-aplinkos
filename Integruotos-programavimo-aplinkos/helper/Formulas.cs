using System;
using System.Collections.Generic;
using System.Text;

namespace Integruotos_programavimo_aplinkos.helper
{
    class Formulas
    {
        /// <summary>
        /// Returns the final grade
        /// </summary>
        /// <param name="vidurkis">avg of the grades</param>
        /// <param name="egzaminas">exam grade</param>
        /// <returns></returns>
        public static double Galutinis(double vidurkis, double egzaminas)
        {
            return (0.3 * vidurkis) + (0.7 * egzaminas);
        }

        /// <summary>
        /// Returns the final grade with mediana
        /// </summary>
        /// <param name="vidurkis">avg of the grades</param>
        /// <param name="egzaminas">exam grade</param>
        /// <returns></returns>
        public static double Galutinis_mediana(List<double> vidurkis, double egzaminas)
        {
            vidurkis.Sort();
            return 0.3 * vidurkis[vidurkis.Count / 2] + (0.7 * egzaminas);
        }
    }
}
