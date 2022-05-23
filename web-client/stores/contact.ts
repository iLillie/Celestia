import { defineStore } from "pinia";
import {mande} from "mande";
import {Contact} from "~/types";

const api = mande('http://localhost:5001/api/Contact');

export const useContacts = defineStore('contacts', {
    state: () => ({
       contacts: [],
    }),
    actions: {
        async getContact(id: number) {
            return this.contacts.push(await api.get(id));
        },
        async getAllJContact() {
            return this.contacts = await api.get("");
        },
        async updateContact(id: number, contact: Contact) {
            return await api.put(id, contact);
        },
        async newContact(contact: Contact) {
            return this.contacts.push(await api.post(contact));
        },
        async deleteContact(id: number) {
            return await api.delete(id);
        }
    }
})
