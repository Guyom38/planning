Public Class Enums
    Public Enum ENUM_Mode_Planning
        Classes
        Salles
        Enseignants
    End Enum
    Public Enum ENUM_Mode_Groupe As Integer
        Groupe1 = 0
        Groupe2 = 1
        Tout = 2
    End Enum

    Enum Enum_Ecran
        Normal
        Normal2x
        Etire
    End Enum

    Enum Enum_Cible
        Classe
        Salle
        Enseignant
        Matiere
    End Enum




    Public Shared LISTE_JOURS As String() = {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi"}
    Public Shared LISTE_HEURES As String() = {"08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30",
                                        "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00"}

    Public Shared liste_couleurs() As Color = {Color.FromArgb(255, 204, 204), Color.FromArgb(255, 230, 204), Color.FromArgb(255, 255, 204), Color.FromArgb(204, 255, 204), Color.FromArgb(204, 255, 229), Color.FromArgb(204, 255, 255), Color.FromArgb(204, 229, 255), Color.FromArgb(204, 204, 255), Color.FromArgb(229, 204, 255), Color.FromArgb(255, 204, 255), Color.FromArgb(255, 204, 230), Color.FromArgb(255, 204, 204), Color.FromArgb(230, 204, 204), Color.FromArgb(204, 204, 204), Color.FromArgb(230, 255, 204), Color.FromArgb(204, 255, 178), Color.FromArgb(204, 229, 204), Color.FromArgb(178, 204, 229), Color.FromArgb(204, 204, 255), Color.FromArgb(229, 204, 255), Color.FromArgb(255, 204, 255), Color.FromArgb(255, 204, 229), Color.FromArgb(255, 204, 204), Color.FromArgb(255, 229, 204), Color.FromArgb(255, 255, 204), Color.FromArgb(204, 255, 204), Color.FromArgb(204, 229, 255), Color.FromArgb(178, 204, 255), Color.FromArgb(204, 204, 229), Color.FromArgb(255, 204, 255), Color.FromArgb(255, 204, 229), Color.FromArgb(255, 204, 204), Color.FromArgb(230, 204, 204), Color.FromArgb(204, 204, 204), Color.FromArgb(255, 230, 204), Color.FromArgb(255, 255, 204), Color.FromArgb(204, 255, 204), Color.FromArgb(204, 229, 255), Color.FromArgb(204, 204, 255), Color.FromArgb(229, 204, 255), Color.FromArgb(255, 204, 255), Color.FromArgb(255, 204, 229), Color.FromArgb(255, 204, 204), Color.FromArgb(230, 204, 204), Color.FromArgb(204, 204, 204), Color.FromArgb(230, 255, 204), Color.FromArgb(204, 255, 178), Color.FromArgb(204, 229, 204), Color.FromArgb(178, 204, 229), Color.FromArgb(204, 204, 255), Color.FromArgb(229, 204, 255), Color.FromArgb(255, 204, 255), Color.FromArgb(255, 204, 229), Color.FromArgb(255, 204, 204), Color.FromArgb(255, 229, 204), Color.FromArgb(255, 255, 204), Color.FromArgb(204, 255, 204), Color.FromArgb(204, 229, 255), Color.FromArgb(178, 204, 255), Color.FromArgb(204, 204, 229), Color.FromArgb(255, 204, 255), Color.FromArgb(255, 204, 229), Color.FromArgb(255, 204, 204)}

End Class
