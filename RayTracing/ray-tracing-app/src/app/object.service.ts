import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Vector } from 'src/model/vector';

@Injectable({
  providedIn: 'root'
})
export class ObjectService {

  constructor(private httpClient: HttpClient) { }
  // post(x: number, y: number, z: number): Observable<Vector>{
  //   return this.httpClient.post<Vector>('https://localhost:7041/object/wektor' + x, y, z);
  // }
  // get():Observable<String>{
  //   return this.httpClient.get<String>('https://localhost:7041/object/siema');
  // }

  public downloadFile()
  {
    return this.httpClient.get("https://localhost:7041/download", 
    {observe:'response', responseType:'blob'})
  }
}
