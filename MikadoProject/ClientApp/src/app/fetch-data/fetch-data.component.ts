import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public users: IUser;
  public medias: IMedia;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<IUser>(baseUrl + 'user/findAll').subscribe(result => {
      this.users = result;
    }, error => console.error(error));

    http.get<IMedia>(baseUrl + 'media/findAll').subscribe(result => {
      this.medias = result;
    }, error => console.error(error));
  }
}

interface IUser {
  nom: string;
  prenom: string;
  login: string;
  password: string;
}

interface IMedia {
  libelle: string;
  description: string;
  auteur: string;
  realisateur: string;
}
