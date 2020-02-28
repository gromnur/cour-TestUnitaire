import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataServiceService {

  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getListUser() {
    return this.http.get<IUser>(this.baseUrl + 'user/findAll')
  }

  getListMedia() {
    return this.http.get<IMedia>(this.baseUrl + 'media/findAll');
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
