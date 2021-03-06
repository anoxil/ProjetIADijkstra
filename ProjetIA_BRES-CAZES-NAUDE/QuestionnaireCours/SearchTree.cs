﻿using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace QuestionnaireCours
{
    class SearchTree
    {
        public List<GenericNode> L_Ouverts;
        public List<GenericNode> L_Fermes;
        public List<String[]> L_FermesEvolution;
        public List<String[]> L_OuvertsEvolution;

        public int CountInOpenList()
        {
            return L_Ouverts.Count;
        }
        public int CountInClosedList()
        {
            return L_Fermes.Count;
        }

        private GenericNode ChercheNodeDansFermes(GenericNode N2)
        {
            int i = 0;

            while (i < L_Fermes.Count)
            {
                if (L_Fermes[i].IsEqual(N2))
                    return L_Fermes[i];
                i++;
            }
            return null;
        }

        private GenericNode ChercheNodeDansOuverts(GenericNode N2)
        {
            int i = 0;

            while (i < L_Ouverts.Count)
            {
                if (L_Ouverts[i].IsEqual(N2))
                    return L_Ouverts[i];
                i++;
            }
            return null;
        }

        /* Retourne la lettre correspondante au node */
        private string[] ToStringList(List<GenericNode> liste)
        {
            string[] nodes = new string[liste.Count];

            for (int i = 0; i < liste.Count; i++)
            {
                nodes[i] = liste[i].ToLetter();
            }

            return nodes;
        }

        /* Fonction principale de résolution de l'algorithme */
        public List<GenericNode> RechercheSolutionAEtoile(GenericNode N0, DijkstraAForm form)
        {
            int ite = 1;
            //Listes qui se remplira des nodes pour la résolution de l'algorithme
            L_Ouverts = new List<GenericNode>();
            L_Fermes = new List<GenericNode>();
            //Liste contenant les solutions string de l'input pour l'utilisateur
            //e.g : si on en est à l'étape 2 de la résolution, la liste L_FermesEvolution contiendra { {"N0"}, {"N0", "N1"} }
            L_OuvertsEvolution = new List<String[]>();
            L_FermesEvolution = new List<String[]>();

            //Le noeud passé en paramètre est supposé être le noeud initial
            GenericNode N = N0;
            L_Ouverts.Add(N0);

            //Enregistrement de l'étape 1
            L_OuvertsEvolution.Add(ToStringList(L_Ouverts));
            L_FermesEvolution.Add(ToStringList(L_Fermes));

            // tant que le noeud n'est pas terminal et que ouverts n'est pas vide
            while (L_Ouverts.Count != 0 && N.EndState() == false)
            {
                ite++;
                // Le meilleur noeud des ouverts est supposé placé en tête de liste
                // On le place dans les fermés
                L_Ouverts.Remove(N);
                L_Fermes.Add(N);

                // Il faut trouver les noeuds successeurs de N
                this.MAJSuccesseurs(N);
                // Inutile de retrier car les insertions ont été faites en respectant l'ordre

                //Enregistrement de l'étape "ite"
                L_OuvertsEvolution.Add(ToStringList(L_Ouverts));
                L_FermesEvolution.Add(ToStringList(L_Fermes));

                // On prend le meilleur, donc celui en position 0, pour continuer à explorer les états
                // A condition qu'il existe bien sûr
                if (L_Ouverts.Count > 0) { N = L_Ouverts[0]; }
                else { N = null; }
            }
            form.SetIterationInputGoal(++ite);

            L_Fermes.Add(N);
            L_Ouverts.Remove(N);
            this.MAJSuccesseurs(N);

            //Enregistrement de la dernière étape
            L_OuvertsEvolution.Add(ToStringList(L_Ouverts));
            L_FermesEvolution.Add(ToStringList(L_Fermes));

            // A* terminé
            // On retourne le chemin qui va du noeud initial au noeud final sous forme de liste
            // Le chemin est retrouvé en partant du noeud final et en accédant aux parents de manière
            // itérative jusqu'à ce qu'on tombe sur le noeud initial
            List<GenericNode> _LN = new List<GenericNode>();
            if (N != null)
            {
                _LN.Add(N);

                while (N != N0)
                {
                    N = N.GetNoeud_Parent();
                    _LN.Insert(0, N);  // On insère en position 1
                }
            }
            return _LN;
        }

        private void MAJSuccesseurs(GenericNode N)
        {
            // On fait appel à GetListSucc, méthode abstraite qu'on doit réécrire pour chaque
            // problème. Elle doit retourner la liste complète des noeuds successeurs de N.
            List<GenericNode> listsucc = N.GetListSucc();
            foreach (GenericNode N2 in listsucc)
            {
                // N2 est-il une copie d'un nœud déjà vu et placé dans la liste des fermés ?
                GenericNode N2bis = ChercheNodeDansFermes(N2);
                if (N2bis == null)
                {
                    // Rien dans les fermés. Est-il dans les ouverts ?
                    N2bis = ChercheNodeDansOuverts(N2);
                    if (N2bis != null)
                    {
                        // Il existe, donc on l'a déjà vu, N2 n'est qu'une copie de N2Bis
                        // Le nouveau chemin passant par N est-il meilleur ?
                        if (N.GetGCost() + N.GetArcCost(N2) < N2bis.GetGCost())
                        {
                            // Mise à jour de N2bis
                            N2bis.SetGCost(N.GetGCost() + N.GetArcCost(N2));
                            // HCost pas recalculé car toujours bon
                            N2bis.RecalculeCoutTotal(); // somme de GCost et HCost
                            // Mise à jour de la famille ....
                            N2bis.Supprime_Liens_Parent();
                            N2bis.SetNoeud_Parent(N);
                            // Mise à jour des ouverts
                            L_Ouverts.Remove(N2bis);
                            this.InsertNewNodeInOpenList(N2bis);
                        }
                        // else on ne fait rien, car le nouveau chemin est moins bon
                    }
                    else
                    {
                        // N2 est nouveau, MAJ et insertion dans les ouverts
                        N2.SetGCost(N.GetGCost() + N.GetArcCost(N2));
                        N2.SetNoeud_Parent(N);
                        N2.calculCoutTotal(); // somme de GCost et HCost
                        this.InsertNewNodeInOpenList(N2);
                    }
                }
                // else il est dans les fermés donc on ne fait rien,
                // car on a déjà trouvé le plus court chemin pour aller en N2
            }
        }

        public void InsertNewNodeInOpenList(GenericNode NewNode)
        {
            // Insertion pour respecter l'ordre du cout total le plus petit au plus grand
            if (this.L_Ouverts.Count == 0)
            { L_Ouverts.Add(NewNode); }
            else
            {
                GenericNode N = L_Ouverts[0];
                bool trouve = false;
                int i = 0;
                do
                    if (NewNode.Cout_Total < N.Cout_Total)
                    {
                        L_Ouverts.Insert(i, NewNode);
                        trouve = true;
                    }
                    else
                    {
                        i++;
                        if (L_Ouverts.Count == i)
                        {
                            N = null;
                            L_Ouverts.Insert(i, NewNode);
                        }
                        else
                        { N = L_Ouverts[i]; }
                    }
                while ((N != null) && (trouve == false));
            }
        }

        // Si on veut afficher l'arbre de recherche, il suffit de passer un treeview en paramètres
        // Celui-ci est mis à jour avec les noeuds de la liste des fermés, on ne tient pas compte des ouverts
        public void GetSearchTree(TreeView TV, bool filled)
        {
            if (L_Fermes == null) return;
            if (L_Fermes.Count == 0) return;

            // On suppose le TreeView préexistant
            TV.Nodes.Clear();

            string txt = "___";
            if (filled) { txt = L_Fermes[0].ToLetter() + ":" + L_Fermes[0].GetGCost().ToString(); }
            TreeNode TN = new TreeNode(txt);
            TV.Nodes.Add(TN);

            AjouteBranche(L_Fermes[0], TN, filled);
        }

        // AjouteBranche est exclusivement appelée par GetSearchTree; les noeuds sont ajoutés de manière récursive
        private void AjouteBranche(GenericNode GN, TreeNode TN, bool filled)
        {
            foreach (GenericNode GNfils in GN.GetEnfants())
            {
                string txt = "___";
                if (filled) { txt = GNfils.ToLetter() + ":" + GNfils.GetGCost().ToString(); }
                TreeNode TNfils = new TreeNode(txt);
                TN.Nodes.Add(TNfils);
                if (GNfils.GetEnfants().Count > 0) AjouteBranche(GNfils, TNfils, filled);
            }
        }

    }
}
