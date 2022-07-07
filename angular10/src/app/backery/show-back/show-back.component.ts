import { Component, OnInit, ViewChild,ElementRef } from '@angular/core';
import {SharedService} from '../../shared.service';
import { timer,Observable,Subscription } from 'rxjs';

@Component({
  selector: 'app-show-back',
  templateUrl: './show-back.component.html',
  styleUrls: ['./show-back.component.css']
})
export class ShowBackComponent implements OnInit {

  constructor(private service:SharedService) { }

  BackeryList:any=[];
  @ViewChild('exampleModalCloseButton') closeModal: ElementRef;

  ModalTitle:string;
  ActivateAddEditBackComp:boolean=false;
  back:any;
  every10Seconds: Observable<number> = timer(0, 10000);
  subscription: Subscription;

  ngOnInit(): void {
    this.refreshBackList();
    this.subscription = this.every10Seconds.subscribe(() => {
      this.refreshBackList();
    });
  }
  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
  createBackeryItems(){
    this.ActivateAddEditBackComp = true;
  }
  
  closeClick(){
    this.ActivateAddEditBackComp=false;
  }
  
  closeCreate(){
    this.ActivateAddEditBackComp=false;
    this.closeModal.nativeElement.click();
    this.refreshBackList();
  }

  refreshBackList(){
    this.service.getBackeryItems().subscribe(data=>{
      this.BackeryList=data;
    });
  }

}

