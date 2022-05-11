<template>
  <div class="fixed inset-0 w-full h-full z-10">
    <div class=" w-full h-full grid place-items-center">
      <article :class="updateHeight" class="grid bg-white p-8 w-1/3 z-20 rounded-md gap-2 max-h-50vh overflow-y-auto">
        <div class="flex items-center justify-between">
          <Breadcrumbs/>
          <IconButton icon="ri-close-fill" @onClick="$emit('closeModal')" />
        </div>

        <div class="flex items-center justify-between">
          <h3 class="text-3xl leading-none font-semibold">Utvikler</h3>
          <div class="flex gap-2">
            <IconButton :has-shadow="true" icon="ri-pencil-fill" @onClick="$emit('closeModal')" />
            <IconButton :has-shadow="true" icon="ri-more-fill" @onClick="$emit('closeModal')" />
          </div>
        </div>

        <a class="text-blue-400 underline hover:text-blue-600" href="https://finn.no/job/fulltime/ad.html?finnkode=257432123" target="_blank">
          finn.no/job/fulltime/ad.html?finnkode=257432123
        </a>
        <Dropdown title="Detaljer">
          <div class="grid">
            <div class="flex">
              <p class="w-24">Selskap</p>
              <p>Statkraft Mer Holding AS</p>
            </div>
            <div class="flex">
              <p class="w-24">Selskap</p>
              <p>Statkraft Mer Holding AS</p>
            </div>
            <div class="flex">
              <p class="w-24">Selskap</p>
              <p>Statkraft Mer Holding AS</p>
            </div>
          </div>
        </Dropdown>
        <Dropdown title="Detaljer">
          <div class="grid">
            <div class="flex">
              <p class="w-24">Selskap</p>
              <p>Statkraft Mer Holding AS</p>
            </div>
            <div class="flex">
              <p class="w-24">Selskap</p>
              <p>Statkraft Mer Holding AS</p>
            </div>
            <div class="flex">
              <p class="w-24">Selskap</p>
              <p>Statkraft Mer Holding AS</p>
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
