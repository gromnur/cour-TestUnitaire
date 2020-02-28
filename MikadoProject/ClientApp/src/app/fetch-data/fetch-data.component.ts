import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataServiceService } from '../data-service.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {

  private medias;
  private users;

  constructor(private data: DataServiceService, @Inject('BASE_URL') baseUrl: string) {
    data.getListMedia().subscribe(resultat => {
       this.medias = resultat;
    })

    data.getListUser().subscribe(resultat => {
      this.users = resultat;
    })
  }
}
