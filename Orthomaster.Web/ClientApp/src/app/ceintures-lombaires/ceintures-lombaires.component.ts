import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ceintures-lombaires',
  templateUrl: './ceintures-lombaires.component.html',
  styleUrls: ['./ceintures-lombaires.component.css']
})

export class CeinturesLombairesComponent implements OnInit {
  projets = ['Antalgie',   'Protéger le mouvement',  'Éviter une récidive',  
            'Retrouver le mouvement', 'Restaurer un tonus musculaire'];

  symptomatologie = ['douleur irradiante dans la jambe',
  'blocage musculaire',
  'périodes de crise',
  'raideur matinale',
  'grossesse'];
  
  private defaultSearch : SearchInfoDTO;  

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
      attentesPersonnelles: 1
     };
  }

  fetchData()  {
    this.webClient.post<Term[]>(this.baseUrl + 'ceintureslombaires/search', this.defaultSearch ).subscribe(result => {

    }, error => console.error(error));
  }  
  
  ngOnInit() {
  }
}

interface ProjetQueryDTO{
  projet :number
}

interface Term {
  interest: number;
  totalAmount: number;
  amortizedCapital: number;
  remainingCapital: number;
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
}
