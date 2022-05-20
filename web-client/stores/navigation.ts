import { defineStore } from "pinia";
import {mande} from "mande";
import {Company} from "~/types";


export const useNavigation = defineStore('navigation', {
    state: () => ({
        isCollapsed: false,
    }),
    actions: {
        collapse() {
            this.isCollapsed = true;
        },
        open() {
            this.isCollapsed = false;
        },
        update() {
            this.isCollapsed = !this.isCollapsed;
        }
    }
})
