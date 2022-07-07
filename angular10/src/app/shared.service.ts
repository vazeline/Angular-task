import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:53535/api";

  constructor(private http:HttpClient) { }

  createBackeryItems(val:number){
    return this.http.post<any[]>(this.APIUrl+'/backery/createbackeryitems',val);
  }


  getBackeryItems():Observable<any[]>{
    return this.http.get<any[]>(this.APIUrl+'/backery/getbackeryitems');
  }

}
