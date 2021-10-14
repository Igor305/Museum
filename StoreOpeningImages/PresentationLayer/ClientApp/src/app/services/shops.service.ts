import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FileContentResponseModel } from '../models/response/file.content.model';

@Injectable({
  providedIn: 'root'
})
export class ShopsService {

  constructor(private http: HttpClient) { }

  public async getImages(shopId: number): Promise<FileContentResponseModel>{
    const url: string = "/api/shops/getImages?shopId="+ shopId;
    const images = await this.http.get<FileContentResponseModel>(url).toPromise();

    return images;
  }
}