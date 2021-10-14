import { Component, ElementRef } from '@angular/core';
import { FileContentResponseModel } from '../models/response/file.content.model';
import { ShopsService } from '../services/shops.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent {

  shopNumber: string = "";
  images: FileContentResponseModel;
  img : ArrayBuffer;
  numberImg : number = 0;
  timer : NodeJS.Timeout;

  constructor(private shopsService : ShopsService,private host: ElementRef){
  }

  public async onEnter(){

    if (this.shopNumber.length == 0){

      this.nextImage();
    }

    if (this.shopNumber.length != 0){
    this.numberImg = 0;
    clearInterval(this.timer);
    this.timer = setInterval(()=> this.nextImage(), 3000);
    this.images = await this.shopsService.getImages(Number.parseInt(this.shopNumber));
    this.shopNumber = "";
    }

     this.getImage();
  }

  public getImage()
  {
    this.img = this.images.fileContentModels[this.numberImg].content;
  }

  public nextImage(){

    console.log(this.images.fileContentModels);
    if (this.images.fileContentModels.length == this.numberImg+1){
      this.images = null;
    }
    if (this.images.fileContentModels.length != this.numberImg+1){
      this.numberImg++;
    }

    this.getImage();
  }

  public previousImage(){

    if (this.numberImg == 0)
    {
      this.numberImg = this.images.fileContentModels.length-1;
    }
    else{
      this.numberImg--;
    }

    this.getImage();
  }
}