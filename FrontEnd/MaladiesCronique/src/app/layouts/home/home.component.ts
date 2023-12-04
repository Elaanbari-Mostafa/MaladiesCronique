import { Component } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  items: MenuItem[] | undefined;

  ngOnInit() {
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