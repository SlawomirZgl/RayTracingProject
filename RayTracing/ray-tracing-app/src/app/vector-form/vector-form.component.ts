import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Vector } from 'src/model/vector';
import { ObjectService } from '../object.service';

@Component({
  selector: 'app-vector-form',
  templateUrl: './vector-form.component.html',
  styleUrls: ['./vector-form.component.css']
})
export class VectorFormComponent implements OnInit {
  // private vector: Vector
  // private x: number;
  // private y: number;
  // private z: number;
  //private tekst: String = ""

  constructor(private activatedRoute: ActivatedRoute,
    private objectService: ObjectService,
    private router: Router) 
    { }

  ngOnInit(): void {     
      // this.objectService.get().subscribe(res => console.log(res));
      // console.log("AAAAAAAAAAAAAAAAAAAAAAA");
  }

  onSubmit(event: NgForm): void {
      // this.objectService.post(this.x, this.y, this.z).subscribe(res =>{
      //   console.log(res);
      // })
  }

}
