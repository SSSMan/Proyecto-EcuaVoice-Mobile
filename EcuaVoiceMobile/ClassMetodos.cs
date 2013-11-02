using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcuaVoiceMobile
{
    class ClassMetodos
    {
        public int vocal(char pal)
        {
            if (pal == 'a' || pal == 'e' || pal == 'i' || pal == 'o' || pal == 'u' || pal == 'A' || pal == 'E' || pal == 'I' || pal == 'O' || pal == 'U')
                return (1);
            else
                return (0);
        }

        public int RL(char letra)
        {
            if (letra == 'r' || letra == 'l' || letra == 'R' || letra == 'S')
                return (1);
            else
                return (0);
        }

        public int posicion(string cad, int pos)
        {
            if (pos <= cad.Length)
            {
                if (pos + 4 == cad.Length && vocal(cad[pos]) == 0 && vocal(cad[pos + 1]) == 0 && vocal(cad[pos + 2]) == 1 && vocal(cad[pos + 3]) == 0)
                    return (4);
                else
                    if (pos + 3 <= cad.Length && vocal(cad[pos]) == 0 && vocal(cad[pos + 1]) == 1 && cad[pos + 2] == 'y')
                        return (3);
                    else
                        if (pos + 3 <= cad.Length && vocal(cad[pos]) == 0 && RL(cad[pos + 1]) == 1 && vocal(cad[pos + 2]) == 1)
                            return (3);
                        else
                            if (pos + 4 <= cad.Length && vocal(cad[pos]) == 0 && vocal(cad[pos + 1]) == 0 && vocal(cad[pos + 2]) == 1 && vocal(cad[pos + 3]) == 0)
                                return (4);
                            else
                                if (pos + 3 <= cad.Length && vocal(cad[pos]) == 0 && vocal(cad[pos + 1]) == 1 && vocal(cad[pos + 2]) == 1)
                                    return (3);
                                else
                                    if (pos + 4 <= cad.Length && vocal(cad[pos]) == 0 && vocal(cad[pos + 1]) == 1 && vocal(cad[pos + 2]) == 0 && vocal(cad[pos + 3]) == 1)
                                        return (2);
                                    else
                                        if (cad.Length - pos == 3)
                                            return (3);
                                        else
                                            if (pos + 2 <= cad.Length && vocal(cad[pos]) == 0 && vocal(cad[pos + 1]) == 1)
                                                return (2);
                                            else
                                                if (pos == 0 || cad[pos - 1] == ' ' && vocal(cad[pos]) == 1 && vocal(cad[pos + 1]) == 0 && vocal(cad[pos + 2]) == 1)
                                                    return (1);
                                                else
                                                    return (2);
            }
            return (0);
        }
    }
}
