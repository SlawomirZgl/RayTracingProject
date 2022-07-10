import { Component } from '@angular/core';
import { ObjectService } from './object.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ray-tracing-app';
  imageName: string ="";

  constructor(private objectService: ObjectService){

  }

  public downloadFile() : void {
    this.objectService.downloadFile().
    subscribe(res => 
      {
        let fileName = res.headers.get('content-disposition')
        ?.split(';')[1].split('=')[1];
        let blob:Blob=res.body as Blob;
        let a = document.createElement('a');
        a.download=fileName!;
        this.imageName=fileName!;
        a.href = window.URL.createObjectURL(blob);
        a.click();
      })
  }
}
