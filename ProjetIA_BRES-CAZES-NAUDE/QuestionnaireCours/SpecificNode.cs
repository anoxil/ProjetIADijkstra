using System;
using System.Collections.Generic;

namespace QuestionnaireCours
{
    public class SpecificNode : GenericNode
    {
        public int numero;

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            SpecificNode N2bis = (SpecificNode)N2;

            return numero == N2bis.numero;
        }

        public override double GetArcCost(GenericNode N2)
        {
            SpecificNode N2bis = (SpecificNode)N2;
            return DijkstraAForm.matrice[numero, N2bis.numero];
        }

        public override bool EndState()
        {
            return (numero == DijkstraAForm.numFinal);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i = 0; i < DijkstraAForm.nbNodes; i++)
            {
                if (DijkstraAForm.matrice[numero, i] != -1)
                {
                    SpecificNode newnode2 = new SpecificNode();
                    newnode2.numero = i;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }


        public override double CalculeHCost()
        {
            return (0);
        }

        public override string ToString()
        {
            return Convert.ToString(numero);
        }
    }
}

