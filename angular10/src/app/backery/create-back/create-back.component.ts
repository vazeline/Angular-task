import { Component, OnInit,Input,Output, EventEmitter } from '@angular/core';
import {SharedService} from '../../shared.service';

@Component({
  selector: 'app-create-back',
  templateUrl: './create-back.component.html',
  styleUrls: ['./create-back.component.css']
})
export class CreateBackComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Output() close:EventEmitter<any> = new EventEmitter<any>();
  count:number;
  BackeryList:any=[];

  ngOnInit(): void {
}

  createBackeryItems(){
    this.service.createBackeryItems(this.count).subscribe((data:any)=>{
      this.BackeryList=data;
      this.close.emit(true);
     // alert(res.toString());
    });
  }


}

