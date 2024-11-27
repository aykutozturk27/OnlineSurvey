import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListResponseModel } from '../models/listResponseModel';
import { Option } from '../models/option';
import { environment } from 'src/environments/environment';
import { ResponseModel } from '../models/responseModel';
import { OptionModel } from '../models/optionModel';

@Injectable({
  providedIn: 'root',
})
export class OptionService {
  
  constructor(private httpClient: HttpClient) {}

  getOptions(): Observable<ListResponseModel<OptionModel>>{
    let newPath = environment.apiUrl + "options/getall";
    return this.httpClient.get<ListResponseModel<OptionModel>>(newPath);
  }

  add(option: Option) : Observable<ResponseModel>{
    return this.httpClient.post<ResponseModel>(environment.apiUrl + "options/add", option);
  }
}
