import { Injectable, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  dataUpdated = new EventEmitter<string>();

  updateData(message: string) {
    this.dataUpdated.emit(message);
  }
}