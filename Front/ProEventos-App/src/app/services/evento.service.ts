import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Evento } from '../models/Evento';

@Injectable(
// {providedIn: 'root'}
)
export class EventoService {
  getEventos() {
    throw new Error('Method not implemented.');
  }
  baseURL = 'https://localhost:5001/api/eventos';

constructor(private http: HttpClient) { }

getEvento(): Observable<Evento[]> {
  return this.http.get<Evento[]>(this.baseURL);
}

getEventoByTema(tema : string): Observable<Evento[]> {
  return this.http.get<Evento[]>(`${this.baseURL}/${tema}/tema`);
}

getEventoById(id: number): Observable<Evento> {
  return this.http.get<Evento>(`${this.baseURL}/${id}`);
}

}