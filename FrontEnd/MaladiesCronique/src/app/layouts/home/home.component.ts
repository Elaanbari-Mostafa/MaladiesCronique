import { Component, AfterViewInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { DataService } from 'src/app/configs/dataService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements AfterViewInit {
  constructor(private dataService: DataService) { }
  items: MenuItem[] | undefined;
  isUserConnected: boolean = false;

  ngAfterViewInit() {
    var test ;
    this.dataService.dataUpdated.subscribe((message) => {
      test = Boolean(message);
    });
    if (localStorage.getItem("_profile") || test) {
      console.log(test);
      this.isUserConnected = true;
    } else {
      this.isUserConnected = false;
    }
  }

  ngOnInit() {
    // this.dataService.dataUpdated.subscribe((message) => {
    //   this.isUserConnected = Boolean(message);
    // });
    this.items = [
      {
        label: 'Patients',
        icon: 'pi pi-users',
        url: '/auth/login',
      },
      {
        label: 'Consultations',
        icon: 'pi pi-file',
      },

    ];
  }
}
