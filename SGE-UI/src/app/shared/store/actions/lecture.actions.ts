import { createAction, props } from '@ngrx/store';
import { type } from '../utils';

const act = (text: string) => type(`[Palestra] - ${text}`);

export const get = createAction(act('Obter valores'));

export const updateLecture = createAction(
  act('Atualizar palestra'),
  props<{ response: any }>()
);
