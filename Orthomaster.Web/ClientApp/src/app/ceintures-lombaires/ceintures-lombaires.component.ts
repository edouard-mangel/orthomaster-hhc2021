import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ceintures-lombaires',
  templateUrl: './ceintures-lombaires.component.html',
  styleUrls: ['./ceintures-lombaires.component.css']
})

export class CeinturesLombairesComponent implements OnInit {
  projets = ['', 'Antalgie',   'Protéger le mouvement',  'Éviter une récidive',  
            'Retrouver le mouvement', 'Restaurer un tonus musculaire'];

  symptomatologie = ['','Douleur irradiante dans la jambe', 'Blocage musculaire', 'Périodes de crise',
                      'Raideur matinale', 'Grossesse'];

  attentesPersonnelles= ['', 'Souplesse ','Légèreté', 'Facilité de mise en place', 'Maintien fort',
    'Douceur du tissu', 'Discretion', 'Résistance/durabilité', 'Choix de coloris'];

    morphologies= ['', 'Poitrine généreuse', 'Taille de guêpe', 'Ventre bedonnant', 'Hanches larges', 'Hyperlordose', 'Délordose', 'Grosses cuisses' ]
    activites= ['', 'Sédentaire', 'Actif / tonique', 'Assis longtemps', 'Activité de force', 'Grande mobilité', 'Transpiration' ]


  private defaultSearch : SearchInfoDTO;  
  private ceintures : Ceinture[];
  public currentCount = 0;

 
  private webClient: HttpClient ;
  private baseUrl: string;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.webClient = http;
    this.baseUrl = baseUrl;
    this.defaultSearch = {
      projet : 1,            
      symptomatologie : 1,
      contreIndication: 1,
      morphologie: 1,
      mesure: 1,
      activite: 1,
      taillePatient: 1,
      attentesPersonnelles: 1,
      compteur: 1
     };
  }

  fetchData()  {
    this.webClient.post<Ceinture[]>(this.baseUrl + 'ceintureslombaires/search', this.defaultSearch ).subscribe(result => {
      this.ceintures = result;
    }, error => console.error(error));
    this.defaultSearch.compteur++;
  }  
  
  ngOnInit() {
  }
  
  changeProjet($event){
    this.defaultSearch.projet = this.projets.indexOf($event.target.value);
    console.log(this.defaultSearch.projet);
    }
    
    changeSymptomatologie($event){
    this.defaultSearch.symptomatologie = this.symptomatologie.indexOf($event.target.value);
    console.log(this.defaultSearch.projet);
    }
    
    changeMorphologie($event){
    this.defaultSearch.morphologie = this.morphologies.indexOf($event.target.value) ;
    console.log(this.defaultSearch.projet);
    }
    
    changeActivite($event){
    this.defaultSearch.activite = this.activites.indexOf($event.target.value) ;
    console.log(this.defaultSearch.projet);
    }
    
    changeAttentes($event){
    this.defaultSearch.attentesPersonnelles = this.attentesPersonnelles.indexOf($event.target.value) ;
    console.log(this.defaultSearch.projet);
    }
}


interface Ceinture {
  numero: number;
  imgURL: string;
  nom: string;
  nomFabricant: string;
  reference: string;
  couleur: string;
}

interface SearchInfoDTO {
  projet: number;
  symptomatologie : number;
  contreIndication: number;
  morphologie: number;
  mesure: number;
  activite: number;
  taillePatient: number;
  attentesPersonnelles: number;
  compteur:number;
}
