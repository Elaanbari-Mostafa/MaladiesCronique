export default interface Patient {
    Id: string,
    Nom: string,
    Prenom: string,
    Cin: string,
    DateNaissance: Date,
    Adresse: string,
    NumeroOrder: string,
    Sexe: string,
    DateDebutMaladie: Date,
    NumeroTelephone: string,
    TypeDiabete: Int16Array
}