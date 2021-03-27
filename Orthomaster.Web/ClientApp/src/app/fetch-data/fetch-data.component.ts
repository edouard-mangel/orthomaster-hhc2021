import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public terms: Term[];
  private defaultSearch : SearchInfoDTO;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.defaultSearch = {
      projet : 1,            
      symptomatologie : 1,
      contreIndications: 1,
      morphologie: 1,
      taillePatient: 1,
      mesureActivite: 1,
      attentesPersonnelles: 1
     };

    http.post<Term[]>(baseUrl + 'ceintureslombaires/search', this.defaultSearch ).subscribe(result => {
      this.terms = result;
    }, error => console.error(error));
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
  contreIndications: number;
  morphologie: number;
  taillePatient: number;
  mesureActivite: number;
  attentesPersonnelles: number;
}
