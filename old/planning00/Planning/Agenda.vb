Imports Newtonsoft.Json

Public Class CL_Plannings
    Class LienTri
        Public Classe As String = ""
        Public Enseignant As String = ""
        Public Salle As String = ""

        Public Valeur As String = ""
    End Class

    Enum Enum_Cible
        Classe
        Salle
        Enseignant
    End Enum

    Public Shared LISTE_JOURS As String() = {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi"}
    Public Shared LISTE_HEURES As String() = {"08:00", "08:30", "09:00", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30",
                                        "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00"}


    Class Planning
        Public Liste_Creneaux As Dictionary(Of String, LienTri)
        Public Proprietaire As Enum_Cible
        Public Nom As String = ""
        Public Nombre_Heures As Double = 0.0

        Sub New(_proprietaire As Enum_Cible, _nom As String)
            Proprietaire = _proprietaire
            Nom = _nom

            Liste_Creneaux = New Dictionary(Of String, LienTri)

            For Each Heure In CL_Plannings.LISTE_HEURES
                For Each Jour In CL_Plannings.LISTE_JOURS
                    Liste_Creneaux.Add(Jour & " " & Heure, New LienTri)
                Next
            Next


        End Sub
    End Class

    Public Liste_Plannings As New Dictionary(Of String, Planning)
    Public Sub New()
        Liste_Plannings.Add("Amandine", New Planning(Enum_Cible.Enseignant, "Amandine"))
        Liste_Plannings.Add("Clémence", New Planning(Enum_Cible.Enseignant, "Clémence"))
        Liste_Plannings.Add("Elodie", New Planning(Enum_Cible.Enseignant, "Elodie"))
        Liste_Plannings.Add("Daniel", New Planning(Enum_Cible.Enseignant, "Daniel"))

        Liste_Plannings.Add("Salle 204", New Planning(Enum_Cible.Salle, "Salle 204"))
        Liste_Plannings.Add("Salle 206", New Planning(Enum_Cible.Salle, "Salle 206"))

        Liste_Plannings.Add("BTS IG", New Planning(Enum_Cible.Classe, "BTS IG"))
        Liste_Plannings.Add("BACPRO 2", New Planning(Enum_Cible.Classe, "BACPRO 2"))

    End Sub


    Public Sub Sauvegarder(plannings As CL_Plannings, cheminFichier As String)
        Dim json As String = JsonConvert.SerializeObject(plannings)
        IO.File.WriteAllText(cheminFichier, json)
    End Sub

    Public Function Charger(cheminFichier As String) As CL_Plannings
        Dim json As String = IO.File.ReadAllText(cheminFichier)
        Dim plannings As CL_Plannings = JsonConvert.DeserializeObject(Of CL_Plannings)(json)
        Return plannings
    End Function

End Class
