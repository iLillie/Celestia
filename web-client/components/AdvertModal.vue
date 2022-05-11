<template>
  <div class="fixed inset-0 w-full h-full z-10">
    <div class=" w-full h-full grid place-items-center">
      <article :class="updateHeight" class="grid bg-white p-8 w-1/3 z-20 rounded-md gap-2 max-h-50vh overflow-y-auto">
        <div class="flex items-center justify-between">
          <Breadcrumbs :items="['Stillinger', '/', `S-${advert.id}`]"/>
          <IconButton icon="ri-close-fill" @onClick="$emit('closeModal')" />
        </div>

        <div class="flex items-center justify-between">
          <h3 class="text-3xl leading-none font-semibold">{{ advert.title }}</h3>
          <div class="flex gap-2">
            <IconButton :has-shadow="true" icon="ri-pencil-fill" @onClick="$emit('closeModal')" />
            <IconButton :has-shadow="true" icon="ri-more-fill" @onClick="$emit('closeModal')" />
          </div>
        </div>

        <a class="text-blue-400 underline hover:text-blue-600" :href="advert.adLink" target="_blank">
          {{ advert.adLink }}
        </a>
        <Dropdown title="Detaljer">
          <div class="grid ">
            <div class="flex">
              <p class="w-24">Selskap</p>
              <p class="text-lg">{{advert.company}}</p>
            </div>
            <div class="flex">
              <p class="w-24">Status</p>
              <p class="text-lg">Venter</p>
            </div>
            <div class="flex">
              <p class="w-24">Frist</p>
              <p class="text-lg">{{toDateString(advert.deadline)}}</p>
            </div>
            <div class="flex">
              <p class="w-24">Sted</p>
              <p class="text-lg">{{advert.location}}</p>
            </div>
            <div class="flex">
              <p class="w-24">Lønn</p>
              <p class="text-lg">NOK 460.000,-</p>
            </div>
          </div>
        </Dropdown>
        <Dropdown title="Beskrivelse">
          <p class="max-w-lg leading-normal ">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Id donec massa faucibus nunc viverra et feugiat tristique. Dolor vel,
            purus tristique egestas quis nulla aliquam ultrices amet.
            Tempor viverra ornare vitae elementum accumsan. At ornare nisl, elementum hendrerit at proin. Id et.
          </p>
        </Dropdown>
        <Dropdown title="Kontakt">
          <div class="grid ">
            <div class="flex">
              <p class="w-24">Navn</p>
              <p class="text-lg">Nora Hansen</p>
            </div>
            <div class="flex">
              <p class="w-24">Telefon</p>
              <p class="text-lg">+47 123 456 680</p>
            </div>
            <div class="flex">
              <p class="w-24">Epost</p>
              <p class="text-lg">Nora.Hansen@selskap.no</p>
            </div>
          </div>
        </Dropdown>
      </article>
    </div>
    <div class="fixed inset-0 w-full h-full bg-black opacity-20 z-10" @click="$emit('closeModal')">
    </div>
  </div>
</template>


<script>
export default {
  name: "AdvertModal",
  props: {
    id: String
  },
  methods: {
    toDateString(unix) {
      if(unix === undefined) return "Snarest";
      const date = new Date(unix);
      const options = { year: 'numeric', month: 'long', day: 'numeric' };
      return date.toLocaleDateString('no-NB', options);
    }
  },
  computed: {
    advert() {
      return this.$store.state.advert.adverts.find(advert => advert.id === this.$store.state.modal.modalOpenId);
    }
  },
}
</script>

<style scoped>
.max-h-50vh {
  max-height: 80vh;
}
.icon-shadow {
  box-shadow: 0px 0px 1px rgba(0, 0, 0, 0.2), 0px 0px 3px rgba(0, 0, 0, 0.05);
}
</style>
