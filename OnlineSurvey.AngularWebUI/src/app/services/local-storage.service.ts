import { Injectable } from '@angular/core';
import { TokenModel } from '../models/tokenModel';

@Injectable({
  providedIn: 'root'
})
export class LocalStorageService {

  tokenKey: string = 'token';

  constructor() { }

  setToken(tokenValue: TokenModel) {
    localStorage.setItem(this.tokenKey, JSON.stringify(tokenValue));
  }

  getToken(): TokenModel {
    const token = localStorage.getItem(this.tokenKey);
    return token ? JSON.parse(token) : null;
  }

  removeToken() {
    localStorage.removeItem(this.tokenKey);
  }
}