import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Poll } from '../models/poll';
import { Observable } from 'rxjs';
import { ResponseModel } from '../models/responseModel';
import { environment } from 'src/environments/environment';
import { ListResponseModel } from '../models/listResponseModel';
import { SingleResponseModel } from '../models/singleResponseModel';

@Injectable({
  providedIn: 'root'
})
export class PollService {

  constructor(private httpClient: HttpClient) { }

  getPolls(): Observable<ListResponseModel<Poll>>{
    let newPath = environment.apiUrl + "polls/getall";
    return this.httpClient.get<ListResponseModel<Poll>>(newPath);
  }

  getById(id: number): Observable<SingleResponseModel<Poll>>{
    let newPath = environment.apiUrl + "polls/poll-detail/:id" + id;
    return this.httpClient.get<SingleResponseModel<Poll>>(newPath);
  }

  add(poll: Poll) : Observable<ResponseModel>{
    return this.httpClient.post<ResponseModel>(environment.apiUrl + "polls/add", poll);
  }

  getPollResult(pollId: number) : Observable<SingleResponseModel<Poll>> {
    return this.httpClient.get<SingleResponseModel<Poll>>(environment.apiUrl + "polls/getPollResult/:pollId"+ pollId);
  }
}
